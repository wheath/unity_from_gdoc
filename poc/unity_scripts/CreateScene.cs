// Simple script that lets you create a new
// scene, create a cube and an empty game object in the scene
// Save the scene and close the editor
	
using UnityEditor;
using UnityEngine;
using System.IO;

public static class CreateScene {
  static void createScene() {
    Debug.Log("_dbg in createScene");  
    
    EditorApplication.NewScene();
    EditorApplication.ExecuteMenuItem("GameObject/3D Object/Cube");
    EditorApplication.ExecuteMenuItem("GameObject/Create Empty");
	
    EditorApplication.SaveScene("Assets/MyNewScene.unity");
    EditorApplication.Exit(0);
    
  }
}	
