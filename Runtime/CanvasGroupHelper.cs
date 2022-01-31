namespace VISIONSBOX.Extensions {
	using UnityEngine;

	[RequireComponent(typeof(CanvasGroup))]
	public class CanvasGroupHelper : MonoBehaviour {
		protected CanvasGroup canvasGroup;
		public CanvasGroup CanvasGroup {
			get {
				if (!canvasGroup)
					canvasGroup = GetComponent<CanvasGroup>();
				return canvasGroup;
			}
		}

		[ContextMenu("Toggle")]
		public void Toggle() { CanvasGroup.Toggle(); }
		public void Toggle(bool SetValue) { CanvasGroup.Toggle(SetValue); }
		public bool IsVisible() { return CanvasGroup.IsVisible(); }
		[ContextMenu("Show")]
		public void Show() { CanvasGroup.Show(); }
		public void ShowImmediate() { CanvasGroup.ShowImmediate(); }
		[ContextMenu("Hide")]
		public void Hide() { CanvasGroup.Hide(); }
		[ContextMenu("Hide (but keep active)")]
		public void HideButKeepActive() { CanvasGroup.HideButKeepActive(); }
		public void Fade(float Alpha) { CanvasGroup.Fade(Alpha); }
		public void HideImmediate() { CanvasGroup.HideImmediate(); }
	}
}
