// Simple script that lets you create a new
	// scene, create a cube and an empty game object in the scene
	// Save the scene and close the editor
	
	import UnityEditor;
	
	@MenuItem ("Example/Chain Actions and close")
	static function Chain() {
		EditorApplication.NewScene();
		
		EditorApplication.ExecuteMenuItem("GameObject/Create Other/Cube");
		EditorApplication.ExecuteMenuItem("GameObject/Create Empty");
	
		EditorApplication.SaveScene("Assets/MyNewScene.unity");
		EditorApplication.Exit(0);
	}
