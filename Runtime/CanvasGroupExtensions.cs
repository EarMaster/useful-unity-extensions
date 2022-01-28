namespace VISIONSBOX.Extensions {
	using UnityEngine;
	using UnityEngine.UI;
	#if SURGE_TWEEN_AVAILABLE
	using Pixelplacement;
	#endif

	public static class CanvasGroupExtensions {
		public static float ChangeDuration = 0.25f;
		/// <summary>Toggles visibility of the CanvasGroup.</summary>
		public static void Toggle(this CanvasGroup CanvasGroup, bool? SetValue = null) {
			if (SetValue.HasValue) {
				if (SetValue.Value)
					CanvasGroup.Show();
				else
					CanvasGroup.Hide();
			} else {
				if (!CanvasGroup.IsVisible())
					CanvasGroup.Show();
				else
					CanvasGroup.Hide();
			}
		}
		/// <summary>Returns the visibility of a CanvasGroup.</summary>
		public static bool IsVisible(this CanvasGroup CanvasGroup) {
			return CanvasGroup.interactable;
		}
		/// <summary>Makes the CanvasGroup visible.</summary>
		public static void Show(this CanvasGroup CanvasGroup, float? Duration = null, float? Delay = null, bool SetInvisibleBefore = false) {
			#if SURGE_TWEEN_AVAILABLE
			if (!(Application.isEditor && !Application.isPlaying)) {
				if (SetInvisibleBefore)
					CanvasGroup.HideImmediate(false);
				CanvasGroup.interactable = true;
				Tween.CanvasGroupAlpha(CanvasGroup, 1f, Duration.HasValue ? Duration.Value : ChangeDuration, Delay.HasValue ? Delay.Value : 0f, null, Tween.LoopType.None,
				                       () => CanvasGroup.gameObject.SetActive(true), null);
			} else
			#endif
			CanvasGroup.ShowImmediate();
		}
		/// <summary>Makes the CanvasGroup visible immediatly without transition.</summary>
		public static void ShowImmediate(this CanvasGroup CanvasGroup) {
			CanvasGroup.gameObject.SetActive(true);
			CanvasGroup.alpha = 1f;
			CanvasGroup.interactable = true;
		}
		/// <summary>Hides the CanvasGroup.</summary>
		[ContextMenu("Hide")]
		public static void Hide(this CanvasGroup CanvasGroup, float? Duration = null, float? Delay = null, bool SetVisibleBefore = false, bool SetInactive = true) {
			#if SURGE_TWEEN_AVAILABLE
			if (!(Application.isEditor && !Application.isPlaying)) {
				if (SetVisibleBefore)
					CanvasGroup.ShowImmediate();
				CanvasGroup.interactable = false;
				Tween.CanvasGroupAlpha(CanvasGroup, 0f, Duration.HasValue ? Duration.Value : ChangeDuration, Delay.HasValue ? Delay.Value : 0f, null, Tween.LoopType.None,
				                       null, () => { if (SetInactive) CanvasGroup.gameObject.SetActive(false); });
			} else
			#endif
			CanvasGroup.HideImmediate(SetInactive);
		}
		/// <summary>Hides the CanvasGroup, but keeps the GameObject active.</summary>
		public static void HideButKeepActive(this CanvasGroup CanvasGroup, float? Duration = null, float? Delay = null, bool SetVisibleBefore = false) {
			CanvasGroup.Hide(Duration, Delay, SetVisibleBefore, false);
		}
		/// <summary>Fades the CanvasGroup and makes it non-interactible.</summary>
		public static void Fade(this CanvasGroup CanvasGroup, float Alpha, float? Duration) {
			#if SURGE_TWEEN_AVAILABLE
			if (!(Application.isEditor && !Application.isPlaying)) {
				CanvasGroup.interactable = false;
				if (Duration.HasValue)
					Tween.CanvasGroupAlpha(CanvasGroup, Alpha, Duration.Value, 0f);
				else
					Tween.CanvasGroupAlpha(CanvasGroup, Alpha, ChangeDuration, 0f);
			} else
			#endif
			CanvasGroup.alpha = Alpha;
		}
		/// <summary>Hides the CanvasGroup immediatly without transition.</summary>
		public static void HideImmediate(this CanvasGroup CanvasGroup, bool SetInactive = true) {
			if (SetInactive)
				CanvasGroup.gameObject.SetActive(false);
			CanvasGroup.alpha = 0f;
			CanvasGroup.interactable = false;
		}
	}
}
