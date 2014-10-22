using UnityEngine;
using System.Collections;

public class GameMenuScene : MonoBehaviour {
	public Texture backgroundTexture;
	
	void OnGUI(){
		//Display background (tittle)
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
		
		// Displays Buttons
		var tutorialButton = GUI.Button (new Rect (Screen.width * .4f, Screen.height * .45f, Screen.width * .25f, Screen.height * .05f), "Tutorial");
		var newGameButton = GUI.Button (new Rect (Screen.width * .4f, Screen.height * .55f, Screen.width * .25f, Screen.height * .05f), "Nuevo Juego");
		var loadGameButton = GUI.Button (new Rect (Screen.width * .4f, Screen.height * .65f, Screen.width * .25f, Screen.height * .05f), "Continuar Juego");
		var backButton = GUI.Button(new Rect(Screen.height*.01f, Screen.height*.01f, Screen.width*.1f, Screen.height*.05f), "Regresar");

		if (tutorialButton) {
			Application.LoadLevel(7);
		}

		if (newGameButton) {
			Application.LoadLevel(8);
		}

		if (loadGameButton) {
			if(haveSaveData()){
				Application.LoadLevel(9);
			}
		}
		GUI.enabled = true;

		if (backButton){
			Application.LoadLevel(0);
		}
	}

	bool haveSaveData(){
		return false;
	}
}
