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
		public void Toggle() {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.Toggle(!IsVisible());
		}
		public void Toggle(bool SetValue) {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.Toggle(SetValue);
		}
		public void Toggle(bool? SetValue = null) {
			if (SetValue.HasValue)
				Toggle(SetValue.Value);
			else
				Toggle();
		}
		public bool IsVisible() {
			bool GroupVisibility = true;
			foreach (CanvasGroup CanvasGroup in Group)
				GroupVisibility = GroupVisibility && CanvasGroup.IsVisible();
			return GroupVisibility;
		}
		[ContextMenu("Show")]
		public void Show() {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.Show();
		}
		public void Show(float? Duration = null, float? Delay = null, bool SetInvisibleBefore = false) {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.Show(Duration, Delay, SetInvisibleBefore);
		}
		public void ShowImmediate() {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.ShowImmediate();
		}
		[ContextMenu("Hide")]
		public void Hide() {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.Hide();
		}
		public void Hide(float? Duration = null, float? Delay = null, bool SetVisibleBefore = false, bool SetInactive = true) {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.Hide(Duration, Delay, SetVisibleBefore, SetInactive);
		}
		[ContextMenu("Hide (but keep active)")]
		public void HideButKeepActive() {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.HideButKeepActive();
		}
		public void HideButKeepActive(float? Duration = null, float? Delay = null, bool SetVisibleBefore = false) {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.HideButKeepActive(Duration, Delay, SetVisibleBefore);
		}
		public void Fade(float Alpha) {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.Fade(Alpha, null);
		}
		public void Fade(float Alpha, float? Duration) {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.Fade(Alpha, Duration);
		}
		public void HideImmediate() {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.HideImmediate();
		}
		public void HideImmediate(bool SetInactive = true) {
			foreach (CanvasGroup CanvasGroup in Group)
				CanvasGroup.HideImmediate(SetInactive);
		}
	}
}