using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScoresScene : MonoBehaviour {

	public Texture backgroundTexture;
	
	void OnGUI(){
		//Display background (tittle)
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);

		// Displays Buttons
		if (GUI.Button (new Rect (Screen.width * .01f, Screen.height * .01f, Screen.width * .1f, Screen.height * .05f), "Regresar")) {
			Application.LoadLevel(0);
		}

		//Display Player's List
		getListPlayers ();
		drawHeaderList ();
		drawTable ();
	}

	public class player : Object {
		public string nickname, score;
		public player(string nickname, string score){
			this.nickname = nickname;
			this.score = score;
		}
	}

	List<player> players = new List<player>();

	private void drawHeaderList(){
		GUI.color = Color.black;
		GUI.Label(new Rect(Screen.width * .35f, Screen.height * .25f, Screen.width * .1f, Screen.height * .05f), "Posicion");
		GUI.Label(new Rect(Screen.width * .45f, Screen.height * .25f, Screen.width * .1f, Screen.height * .05f), "Nick");
		GUI.Label(new Rect(Screen.width * .55f, Screen.height * .25f, Screen.width * .1f, Screen.height * .05f), "Puntaje");
	}

	private void drawsingleline (int pos, player toShow) {
		GUI.color = Color.black;
		var centeredStyle = GUI.skin.GetStyle("Label");
		centeredStyle.alignment = TextAnchor.UpperCenter;

		GUI.Label(new Rect(Screen.width * .35f ,pos*32 + Screen.height * .30f, 128,32), (pos + 1).ToString(), centeredStyle);
		GUI.Label(new Rect(Screen.width * .45f, pos*32 + Screen.height * .30f, 128,32), toShow.nickname, centeredStyle);
		GUI.Label(new Rect(Screen.width * .55f, pos*32 + Screen.height * .30f, 128,32), toShow.score, centeredStyle);
	}
	
	private void drawTable () {
		int i = 0;
		foreach (player thecont in players) {
			drawsingleline (i, thecont);
			i++;
		}
		players.Clear();
	}

	private void getListPlayers(){
		player p1 = new player ("Player 1","100");
		player p2 = new player ("Player 2","90");
		player p3 = new player ("Player 3","80");
		player p4 = new player ("Player 4","70");
		player p5 = new player ("Player 5","60");
		player p6 = new player ("Player 6","50");
		player p7 = new player ("Player 7","40");
		player p8 = new player ("Player 8","30");
		player p9 = new player ("Player 9","20");
		player p10 = new player ("Player 10","10");

		players.Add (p1);
		players.Add (p2);
		players.Add (p3);
		players.Add (p4);
		players.Add (p5);
		players.Add (p6);
		players.Add (p7);
		players.Add (p8);
		players.Add (p9);
		players.Add (p10);
	}
}
