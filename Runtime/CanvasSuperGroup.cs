namespace VISIONSBOX.Extensions {
	using UnityEngine;
	using UnityEngine.UI;
	using System.Collections.Generic;

	public class CanvasSuperGroup : MonoBehaviour {
		public List<CanvasGroup> Group;
		public bool ActivateOnStart = false;

		public void Start() {
			if (ActivateOnStart)
				ShowImmediate();
		}

		[ContextMenu("Toggle")]
		protected void ToggleInEditor() {
			if (IsVisible())
				Hide();
			else
				Show();
		}

		public void Toggle(bool? SetValue = null) {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.Toggle(SetValue);
		}
		public bool IsVisible() {
			bool GroupVisibility = true;
			foreach (CanvasGroup CanvasGroup in Group)
				GroupVisibility = GroupVisibility && CanvasGroup.IsVisible();
			return GroupVisibility;
		}
		public void Show(float? Duration = null, float? Delay = null, bool SetInvisibleBefore = false) {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.Show(Duration, Delay, SetInvisibleBefore);
		}
		public void ShowImmediate() {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.ShowImmediate();
		}
		public void Hide(float? Duration = null, float? Delay = null, bool SetVisibleBefore = false, bool SetInactive = true) {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.Hide(Duration, Delay, SetVisibleBefore, SetInactive);
		}
		public void HideButKeepActive(float? Duration = null, float? Delay = null, bool SetVisibleBefore = false) {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.HideButKeepActive(Duration, Delay, SetVisibleBefore);
		}
		public void Fade(float Alpha, float? Duration) {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.Fade(Alpha, Duration);
		}
		public void HideImmediate(bool SetInactive = true) {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.HideImmediate(SetInactive);
		}
	}
}