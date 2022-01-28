namespace VISIONSBOX.Extensions {
	using System.Collections.Generic;
	using UnityEngine;
	#if UNITY_EDITOR
	using UnityEditor;
	#endif

	public static class HierarchyExtensions {
		/// <summary>Removes all children from the hierarchy by destroying the <c>GameObject</c>s.</summary>
		public static void Clear(this Transform transform) {
			for (int i = transform.childCount - 1; i >= 0; --i)
				GameObject.DestroyImmediate(transform.GetChild(i).gameObject);
		}
		/// <summary>Sets the <c>GameObject</c> active state including all childrin to the given depth (defaults to 1 meaning only direct children are effected).</summary>
		public static void SetActiveIncludingChildren(this GameObject gameObject, bool State, int Depth = 1) {
			gameObject.SetActive(State);
			if (Depth > 0)
				foreach (Transform Child in gameObject.transform)
					Child.gameObject.SetActiveIncludingChildren(State, Depth - 1);
		}
		/// <summary>Instantiates a Prefab at the given Parent.</summary>
		public static GameObject Instantiate(this GameObject Prefab, Transform Parent) {
			GameObject SpawnedGameObject;
			#if UNITY_EDITOR
			SpawnedGameObject = PrefabUtility.InstantiatePrefab(Prefab, Parent) as GameObject;
			#else
			SpawnedGameObject = GameObject.Instantiate(Prefab, Parent);
			#endif
			return SpawnedGameObject;
		}
	}
}
