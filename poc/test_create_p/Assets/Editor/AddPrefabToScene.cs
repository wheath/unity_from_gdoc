// Simple script that lets you create a new
// scene, create a cube and an empty game object in the scene
// Save the scene and close the editor
	
using UnityEditor;
using UnityEngine;
using System.IO;

public static class AddPrefabToScene {
  static void addPrefab() {
    Debug.Log("_dbg in addPrefab");  
    
    EditorApplication.OpenScene("Assets/MyNewScene.unity");
    GameObject prefab  = (GameObject)Resources.LoadAssetAtPath("Assets/CompletePlayer.prefab", typeof(GameObject));
    UnityEditor.PrefabUtility.InstantiatePrefab(prefab);
	
    EditorApplication.SaveScene("Assets/MyNewScene.unity");
    EditorApplication.Exit(0);
    
  }
}	
