using UnityEngine;
using System.Collections;

public class GameMenuScene : MonoBehaviour {
	public Texture backgroundTexture;
	
	void OnGUI(){
		//Display background (tittle)
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
		
		// Displays Buttons
		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .45f, Screen.width * .25f, Screen.height * .05f), "Tutorial")) {
			Application.LoadLevel(7);
		}

		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .55f, Screen.width * .25f, Screen.height * .05f), "Nuevo Juego")) {
			Application.LoadLevel(8);
		}

		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .65f, Screen.width * .25f, Screen.height * .05f), "Continuar Juego")) {
			Application.LoadLevel(9);
		}

		if (GUI.Button(new Rect(Screen.height*.01f, Screen.height*.01f, Screen.width*.1f, Screen.height*.05f), "Regresar")){
			Application.LoadLevel(0);
		}
	}
}
