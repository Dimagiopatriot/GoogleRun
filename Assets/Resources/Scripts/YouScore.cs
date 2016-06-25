using UnityEngine;
using System.Collections;
[ExecuteInEditMode]

public class YouScore : MonoBehaviour {
	public GUIStyle customLabel;
	public GUIStyle customLabel2;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetString ("Musicon") == "true") {
			GetComponent<AudioSource>().enabled=true;
		}
		if (PlayerPrefs.GetString ("Musicoff") == "true") {
			GetComponent<AudioSource>().enabled=false;
		}

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<GUITexture>().pixelInset = new Rect (Screen.width / 2, Screen.height / 2, 0, 0);

		}
	void OnGUI(){
		if (PlayerPrefs.GetString ("Fullscreen") == "true") {
						customLabel.fontSize = 65;
						customLabel2.fontSize = 45;
			GUI.Label (new Rect (20, 20, 100, 100), "YOU DIED!", customLabel);
			GUI.Label (new Rect (Screen.width - 230, 20, 100, 100), "Score: " + System.IO.File.ReadAllText (@"C:\Scores.txt"), customLabel2);
		}
		if (PlayerPrefs.GetString ("Fullscreen") == "false") {
						customLabel.fontSize = 45;
						customLabel2.fontSize = 25;
						GUI.Label (new Rect (20, 20, 100, 100), "YOU DIED!", customLabel);
						GUI.Label (new Rect (Screen.width - 150, 20, 100, 100), "Score: " + System.IO.File.ReadAllText (@"C:\Scores.txt"), customLabel2);
				}
	}
}