namespace VISIONSBOX.Extensions {
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Linq;
	using System.Reflection;

	/// @see https://stackoverflow.com/a/1340081/1111756
	public static class EnumExtensions {
		private static void CheckIsEnum<T>(bool withFlags) {
			if (!typeof(T).IsEnum)
				throw new ArgumentException(string.Format("Type '{0}' is not an enum", typeof(T).FullName));
			if (withFlags && !Attribute.IsDefined(typeof(T), typeof(FlagsAttribute)))
				throw new ArgumentException(string.Format("Type '{0}' doesn't have the 'Flags' attribute", typeof(T).FullName));
		}

		public static bool IsFlagSet<T>(this T value, T flag) where T : struct {
			CheckIsEnum<T>(true);
			long lValue = Convert.ToInt64(value);
			long lFlag = Convert.ToInt64(flag);
			return (lValue & lFlag) != 0;
		}

		public static IEnumerable<T> GetFlags<T>(this T value) where T : struct {
			CheckIsEnum<T>(true);
			foreach (T flag in Enum.GetValues(typeof(T)).Cast<T>()) {
				if (value.IsFlagSet(flag))
					yield return flag;
			}
		}

		public static T SetFlags<T>(this T value, T flags, bool on) where T : struct {
			CheckIsEnum<T>(true);
			long lValue = Convert.ToInt64(value);
			long lFlag = Convert.ToInt64(flags);
			if (on) {
				lValue |= lFlag;
			} else {
				lValue &= (~lFlag);
			}
			return (T)Enum.ToObject(typeof(T), lValue);
		}

		public static T SetFlags<T>(this T value, T flags) where T : struct {
			return value.SetFlags(flags, true);
		}

		public static T ClearFlags<T>(this T value, T flags) where T : struct {
			return value.SetFlags(flags, false);
		}

		public static T CombineFlags<T>(this IEnumerable<T> flags) where T : struct {
			CheckIsEnum<T>(true);
			long lValue = 0;
			foreach (T flag in flags) {
				long lFlag = Convert.ToInt64(flag);
				lValue |= lFlag;
			}
			return (T)Enum.ToObject(typeof(T), lValue);
		}
		public static T Everything<T>(this T value) where T : struct {
			CheckIsEnum<T>(true);
			long lValue = 0;
			foreach (T flag in Enum.GetValues(typeof(T))) {
				long lFlag = Convert.ToInt64(flag);
				lValue |= lFlag;
			}
			return (T)Enum.ToObject(typeof(T), lValue);
		}
		public static T Nothing<T>(this T value) where T : struct {
			CheckIsEnum<T>(true);
			long lValue = 0;
			return (T)Enum.ToObject(typeof(T), lValue);
		}
		public static string GetDescription<T>(this T value) where T : struct {
			CheckIsEnum<T>(false);
			string name = Enum.GetName(typeof(T), value);
			if (name != null) {
				FieldInfo field = typeof(T).GetField(name);
				if (field != null) {
					DescriptionAttribute attr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
					if (attr != null) {
						return attr.Description;
					}
				}
			}
			return null;
		}
		// TODO: implement (used in static selection helper)
		/*public static bool HasAllFlags<T>(this T value, T checkFlags) where T : struct {
			bool HasAllFlags = true;
			bool HasOtherFlags = false;
			foreach (T Flag in Enum.GetValues(typeof(T)))
				if (checkFlags.HasFlag(Flag) && !value.HasFlag(Flag))
					HasAllFlags = false;
			return HasAllFlags;
		}
		public static bool HasOnlyFlags<T>(this T value, T checkFlags) where T : struct {
			bool HasAllFlags = true;
			bool HasOtherFlags = false;
			foreach (T Flag in Enum.GetValues(typeof(T)))
				if (checkFlags.HasFlag(Flag) && !value.HasFlag(Flag))
					HasAllFlags = false;
				else if (!checkFlags.HasFlag(Flag) && value.HasFlag(Flag))
					HasOtherFlags = true;
			return HasAllFlags && !HasOtherFlags;
		}*/
	}
}
