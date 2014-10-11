using UnityEngine;
using System.Collections;

public class MainScene : MonoBehaviour {
	public Texture backgroundTexture;

	void OnGUI(){
		//Display background (tittle)
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);

		// Displays Buttons
		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .45f, Screen.width * .25f, Screen.height * .05f), "Jugar")) {
			Application.LoadLevel(1); 
		}

		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .55f, Screen.width * .25f, Screen.height * .05f), "Ayuda")) {
			Application.LoadLevel(2);
		}

		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .65f, Screen.width * .25f, Screen.height * .05f), "Mejores Puntajes")) {
			Application.LoadLevel(3);
		}

		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .75f, Screen.width * .25f, Screen.height * .05f), "Creditos")) {
			Application.LoadLevel(4);
		}

	}
}
