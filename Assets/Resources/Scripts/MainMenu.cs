using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class MainMenu : MonoBehaviour {

	// Use this for initialization
    void Start () {
		if (PlayerPrefs.GetString ("Musicon") == "true") {
			GetComponent<AudioSource>().enabled=true;
		}
		if (PlayerPrefs.GetString ("Musicoff") == "true") {
			GetComponent<AudioSource>().enabled=false;
		}
		GetComponent<MainMenu> ().enabled = true;
		GetComponent<Settings> ().enabled = false;
		GetComponent<Authors> ().enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	    GetComponent<GUITexture>().texture = Resources.Load("fronting") as Texture;
		GetComponent<GUITexture>().pixelInset = new Rect (Screen.width / 2, Screen.height / 2, 0, 0);
	}
	void OnGUI(){

		GUI.Box(new Rect (20,20,250,240), "Main Menu");
		if (GUI.Button (new Rect (40, 50, 210, 40), "Play")) {
			Application.LoadLevel("Level");
		
		}
		if (GUI.Button (new Rect (40, 100, 210, 40), "Settings")) {
		    GetComponent<MainMenu>().enabled=false;
			GetComponent<Settings>().enabled=true;
			GetComponent<Authors>().enabled=false;
			GetComponent<AudioSource>().volume=0.4f;
		}
		if (GUI.Button (new Rect (40, 150, 210, 40), "Authors")) {
			GetComponent<MainMenu>().enabled=false;
			GetComponent<Settings>().enabled=false;
			GetComponent<Authors>().enabled=true;
			GetComponent<AudioSource>().volume=0.4f;
				}
		if (GUI.Button (new Rect (40, 200, 210, 40), "Exit")) {
					Application.Quit();
				}
	}
}
