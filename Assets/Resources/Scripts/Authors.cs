using UnityEngine;
using System.Collections;

public class Authors : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<MainMenu> ().enabled = false;
		GetComponent<Settings> ().enabled = false;
		GetComponent<Authors> ().enabled = true;
	}

	// Update is called once per frame
	void Update () {
		GetComponent<GUITexture>().texture = Resources.Load("fronting1") as Texture;
		GetComponent<GUITexture>().pixelInset = new Rect (Screen.width / 2, Screen.height / 2, 0, 0);
	}
	void OnGUI() {
		GUI.Box (new Rect (10, 10, Screen.width-20, Screen.height-66), "The author and main developer of \"Google Run\" is Dima Smishniy. The assistant - Denis Smishniy.\r\n" +
						"Special thanks for idea to Google Corporation and Internet-portal \"Habrahabr\" for education stuff.\r\n"+
		         "Thanks to \"Rednex\" for their song \"Cotton eye Joe\".");
		if (GUI.Button (new Rect (10, Screen.height-46, 50, 30), "Back")) {
			GetComponent<GUITexture>().texture = Resources.Load("fronting") as Texture;
			GetComponent<MainMenu>().enabled=true;
			GetComponent<Settings>().enabled=false;
			GetComponent<Authors>().enabled=false;
			GetComponent<AudioSource>().volume=0.58f;
				}
	}
}
