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

		public void Toggle() { CanvasGroup.Toggle(); }
		public void Toggle(bool SetValue) { CanvasGroup.Toggle(SetValue); }
		public bool IsVisible() { return CanvasGroup.IsVisible(); }
		public void Show() { CanvasGroup.Show(); }
		public void ShowImmediate() { CanvasGroup.ShowImmediate(); }
		public void Hide() { CanvasGroup.Hide(); }
		public void HideButKeepActive() { CanvasGroup.HideButKeepActive(); }
		public void Fade(float Alpha) { CanvasGroup.Fade(Alpha, null); }
		public void HideImmediate() { CanvasGroup.HideImmediate(); }
	}
}
