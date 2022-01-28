namespace VISIONSBOX.Extensions {
	using UnityEngine;

	public static class VectorExtensions {
		/// <summary>Converts <c>Vector3</c> to <c>Vector2</c> (removes z value).</summary
		public static Vector2 xy(this Vector3 v) {
			return new Vector2(v.x, v.y);
		}
		/// <summary>Sets x coordinate of <c>Vector3</c> to a given value.</summary
		public static Vector3 WithX(this Vector3 v, float x) {
			return new Vector3(x, v.y, v.z);
		}
		/// <summary>Sets y coordinate of <c>Vector3</c> to a given value.</summary
		public static Vector3 WithY(this Vector3 v, float y) {
			return new Vector3(v.x, y, v.z);
		}
		/// <summary>Sets z coordinate of <c>Vector3</c> to a given value.</summary
		public static Vector3 WithZ(this Vector3 v, float z) {
			return new Vector3(v.x, v.y, z);
		}
		/// <summary>Sets x coordinate of <c>Vector2</c> to a given value.</summary
		public static Vector2 WithX(this Vector2 v, float x) {
			return new Vector2(x, v.y);
		}
		/// <summary>Sets y coordinate of <c>Vector2</c> to a given value.</summary
		public static Vector2 WithY(this Vector2 v, float y) {
			return new Vector2(v.x, y);
		}
		/// <summary>Sets z coordinate of <c>Vector2</c> to a given value (making it a <c>Vector3</c>)</summary
		public static Vector3 WithZ(this Vector2 v, float z) {
			return new Vector3(v.x, v.y, z);
		}
	}
}
