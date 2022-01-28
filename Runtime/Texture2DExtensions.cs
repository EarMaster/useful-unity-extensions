namespace VISIONSBOX.Extensions {
	using UnityEngine;
	public static class Texture2DExtensions {
		/// <summary>Overlays a <c>Texture2D</c> with another <c>Texture2D</c>.</summary>
		public static void Overlay(this Texture2D Background, Texture2D Overlay) {
			Background.Overlay(Overlay, Vector2Int.zero);
		}
		/// <summary>Overlays a <c>Texture2D</c> with another <c>Texture2D</c>. Offset of the overlay can be defined by an <c>Vector2Int</c>.</summary>
		public static void Overlay(this Texture2D Background, Texture2D Overlay, Vector2Int Offset) {
			for (int x = 0; x < Background.width; x++) {
				for (int y = 0; y < Background.height; y++) {
					if (x >= Offset.x && y >= Offset.y && x < Overlay.width && y < Overlay.height) {
						Color BackgroundColor = Background.GetPixel(x, y);
						Color OverlayColor = Overlay.GetPixel(x - Offset.x, y - Offset.y);
						Color FinalColor = Color.Lerp(BackgroundColor, OverlayColor, OverlayColor.a);
						//FinalColor.a = Mathf.Max(BackgroundColor.a, OverlayColor.a);
						Background.SetPixel(x, y, FinalColor);
					}
				}
			}
			Background.Apply();
		}

		public static void SolidColor(this Texture2D Texture, Color FillColor) {
			for (int x = 0; x < Texture.width; x++)
				for (int y = 0; y < Texture.height; y++)
					Texture.SetPixel(x, y, FillColor);
			Texture.Apply();
		}
	}
}
