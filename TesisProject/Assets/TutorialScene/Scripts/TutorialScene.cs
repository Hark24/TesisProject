using UnityEngine;
using System.Collections;

public class TutorialScene : MonoBehaviour {
	void OnGUI(){
		// Displays Buttons
		GUI.Button (new Rect (Screen.width * .01f, Screen.height * .01f, Screen.width * .1f, Screen.height * .05f), "Tutorial Scene");
	}
}
