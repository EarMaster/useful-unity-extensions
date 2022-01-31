# Useful Unity Extensions
This package extends some default Unity classes with useful methods and tools.

[![openupm](https://img.shields.io/npm/v/com.vx.unityextensions?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.vx.unityextensions/)

## Canvas Group Extensions
### CanvasGroup.Toggle(**bool?** SetValue = *null*)
Toggles visibility of the **CanvasGroup**.
### CanvasGroup.IsVisible() : **bool**
Returns the visibility of a **CanvasGroup** (as **bool**).
### CanvasGroup.Show(**float?** Duration = *null*, **float?** Delay = *null*, **bool** SetInvisibleBefore = *false*)
Makes the **CanvasGroup** visible and interactable.
### CanvasGroup.ShowImmediate()
Makes the **CanvasGroup** visible immediatly without transition
### CanvasGroup.Hide(**float?** Duration = *null*, **float?** Delay = *null*, **bool** SetVisibleBefore = *false*, **bool** SetInactive = *true*)
Hides the **CanvasGroup** and disables the **GameObject**.
### CanvasGroup.HideButKeepActive(**float?** Duration = *null*, **float?** Delay = *null*, **bool** SetVisibleBefore = false)
Hides the **CanvasGroup**, but keeps the **GameObject** active.
### CanvasGroup.Fade(**float** Alpha, **float?** Duration)
Fades the CanvasGroup to a specified Alpha.
### CanvasGroup.HideImmediate(**bool** SetInactive = *true*)
Hides the CanvasGroup immediatly without transition.

## Canvas Group Helpers (components)
### Canvas Group Helper
Add this component to a GameObject with a **CanvasGroup** and access the added methods via UnityEvent picker (e.g. Button OnClick).
### Canvas Super Group
Control multiple **CanvasGroup** with this super group.

## Enum Extensions
### IsFlagSet<T>(T flag) : **bool**
Checks if a specific flag is set in an **enum**
### GetFlags<T>() : **IEnumerable<T>**
Gets only the flags of an **enum** which are set.
### SetFlags<T>(T flags, bool on) : **T**
Changes (multiple) flags by merging an **enum** of the same type.
### SetFlags<T>(T flags) : **T**
Sets (multiple) flags by merging an **enum** of the same type.
### ClearFlags<T>(T flags) : **T**
Unsets (multiple) flags by merging an **enum** of the same type.
<!-- ### CombineFlags<T>(this IEnumerable<T> flags) : **T**
 -->
### Everything<T>() : **T**
Returns an **enum** with every flag set.
### Nothing<T>() : **T**
Returns an **enum** with no flag set.
### string GetDescription<T>()
Get **enum** description attribute.
<!-- ### HasAllFlags<T>(T checkFlags) : **bool**
Checks if all provided flags of an **enum** are set. -->
<!-- ### HasOnlyFlags<T>(T checkFlags) : **bool**
Checks if only the provided flags of an **enum** are set. -->

## Hierarchy Extensions
### Transform.Clear()
Removes all children from the hierarchy by destroying the **GameObject**</c>**s.
### GameObject.SetActiveIncludingChildren(**bool** State, **int** Depth = *1*)
Sets the **GameObject** active state including all childrin to the given depth (defaults to 1 meaning only direct children are effected).
### GameObject.Instantiate(**Transform** Parent)
Instantiates a Prefab at the given Parent.

## Texture2D Extensions
### Texture2D.Overlay(**Texture2D** Overlay)
Overlays a **Texture2D** with another **Texture2D**.
### Texture2D.Overlay(**Texture2D** Overlay, **Vector2Int** Offset)
Overlays a **Texture2D** with another **Texture2D**. Offset of the overlay can be defined by an **Vector2Int**.
### Texture2D.SolidColor(**Color** FillColor)
Fills a **Texture2D** with a solid **Color**.

## Vector Extensions
### Vector3.xy() : **Vector2**
Converts **Vector3** to **Vector2** (removes z value).
### Vector3.WithX(**float** x) : **Vector3**
Sets x coordinate of **Vector3** to a given value.
### Vector3.WithY(**float** y) : **Vector3**
Sets y coordinate of **Vector3** to a given value.
### Vector3.WithZ(**float** z) : **Vector3**
Sets z coordinate of **Vector3** to a given value.
### Vector2.WithX(**float** x) : **Vector2**
Sets x coordinate of **Vector2** to a given value.
### Vector2.WithY(**float** y) : **Vector2**
Sets y coordinate of **Vector2** to a given value.
### Vector2.WithZ(**float** z) : **Vector3**
Sets z coordinate of **Vector2** to a given value (making it a **Vector3**).
