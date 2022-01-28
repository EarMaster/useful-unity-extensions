# Useful Unity Extensions
This package extends some default Unity classes with useful methods and tools.

## Canvas Group Extensions
Options: float ChangeDuration = 0.25f;
### void Toggle(this CanvasGroup CanvasGroup, bool? SetValue = null)
### bool IsVisible(this CanvasGroup CanvasGroup)
### void Show(this CanvasGroup CanvasGroup, float? Duration = null, float? Delay = null, bool SetInvisibleBefore = false)
### void ShowImmediate(this CanvasGroup CanvasGroup)
### void Hide(this CanvasGroup CanvasGroup, float? Duration = null, float? Delay = null, bool SetVisibleBefore = false, bool SetInactive = true)
### void HideButKeepActive(this CanvasGroup CanvasGroup, float? Duration = null, float? Delay = null, bool SetVisibleBefore = false)
### void Fade(this CanvasGroup CanvasGroup, float Alpha, float? Duration)
### void HideImmediate(this CanvasGroup CanvasGroup, bool SetInactive = true)

## Enum Extensions
### bool IsFlagSet<T>(this T value, T flag) where T : struct
### public static IEnumerable<T> GetFlags<T>(this T value) where T : struct
### public static T SetFlags<T>(this T value, T flags, bool on) where T : struct
### public static T SetFlags<T>(this T value, T flags) where T : struct
### public static T ClearFlags<T>(this T value, T flags) where T : struct
### public static T CombineFlags<T>(this IEnumerable<T> flags) where T : struct
### public static T Everything<T>(this T value) where T : struct
### public static T Nothing<T>(this T value) where T : struct
### public static string GetDescription<T>(this T value) where T : struct
<!-- ### bool HasAllFlags<T>(this T value, T checkFlags) where T : struct -->
<!-- ### bool HasOnlyFlags<T>(this T value, T checkFlags) where T : struct -->

## Hierarchy Extensions
### void Clear(this Transform transform)
### void SetActiveIncludingChildren(this GameObject gameObject, bool State, int Depth = 1)
### GameObject Instantiate(this GameObject Prefab, Transform Parent)

## Texture2D Extensions
### void Overlay(this Texture2D Background, Texture2D Overlay)
### void Overlay(this Texture2D Background, Texture2D Overlay, Vector2Int Offset)
### void SolidColor(this Texture2D Texture, Color FillColor)

## Vector Extensions
### Vector2 xy(this Vector3 v)
### Vector3 WithX(this Vector3 v, float x)
### Vector3 WithY(this Vector3 v, float y)
### Vector3 WithZ(this Vector3 v, float z)
### Vector2 WithX(this Vector2 v, float x)
### Vector2 WithY(this Vector2 v, float y)
### Vector3 WithZ(this Vector2 v, float z)
### Vector3 NearestPointOnAxis(this Vector3 axisDirection, Vector3 point, bool isNormalized = false)
### Vector3 NearestPointOnLine(this Vector3 lineDirection, Vector3 point, Vector3 pointOnLine, bool isNormalized = false)
