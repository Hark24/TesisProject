using UnityEngine;
using System.Collections;

public class ScoresScene : MonoBehaviour {

	public Texture backgroundTexture;
	
	void OnGUI(){
		//Display background (tittle)
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
		
		// Displays Buttons
		if (GUI.Button (new Rect (Screen.width * .01f, Screen.height * .01f, Screen.width * .1f, Screen.height * .05f), "Regresar")) {
			Application.LoadLevel(0);
		}
	}
}
