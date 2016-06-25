using UnityEngine;
using System.Collections;

public class Settings : MonoBehaviour {

	public float Slider;
	public bool musicon=true;
	public bool musicoff=false;
	public bool fullscreen = false;
	public new Rect button=new Rect (210, 170, 80, 20);
	public new Rect exit = new Rect (10, 170, 80, 20);
	public string word="Exit";
	public string words = "Save & Exit";

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetString ("Musicon") == "true") {
			musicon=true;
			musicoff=false;
			GetComponent<AudioSource>().enabled=true;
		}
		if (PlayerPrefs.GetString ("Musicoff") == "true") {
			musicon=false;
			musicoff=true;
			GetComponent<AudioSource>().enabled=false;
		}
		if (PlayerPrefs.GetString("Fullscreen","true")=="true"){
			fullscreen=true;
		} else{
			fullscreen=false;
		}
		GetComponent<Settings> ().enabled = true;
		GetComponent<MainMenu> ().enabled = false;
		GetComponent<Authors> ().enabled = false;
		Slider = 5.0f;
		Slider =PlayerPrefs.GetFloat("Slider");
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<GUITexture>().texture = Resources.Load("fronting1") as Texture;
		GetComponent<GUITexture>().pixelInset = new Rect (Screen.width / 2, Screen.height / 2, 0, 0);
	}
	void OnGUI() {
		GUI.BeginGroup (new Rect (Screen.width / 2 - 150, Screen.height / 2 - 100, 300, 200));
		GUI.Box (new Rect (0, 0, 300, 200), "Settings");
		GUI.Label (new Rect (10, 30, 65, 20), "Resolution:");
		Slider = GUI.HorizontalSlider (new Rect (80, 35, 135, 20), Slider, 5.0f, 9.0f);
		if (Slider >= 5.0f && Slider <= 6.0f) {
				GUI.Box (new Rect (220, 30, 70, 22), "640x480");
		}
		if (Slider >= 6.0f && Slider <= 7.0f) {
				GUI.Box (new Rect (220, 30, 70, 22), "710x326");
		}
		if (Slider >= 7.0f && Slider <= 8.0f) {
				GUI.Box (new Rect (220, 30, 70, 22), "1280x720");
		}
		if (Slider >= 8.0f && Slider <= 9.0f) {
				GUI.Box (new Rect (220, 30, 70, 22), "1024x768");
		}
		if (GUI.Toggle (new Rect (80, 50, 90, 20), fullscreen, "Fullscreen")) {
						fullscreen = true;
				} else {
			fullscreen=false;
				}
		if (fullscreen == true) {
			saving(1366,768);
		}
		GUI.Label (new Rect (10, 70, 40, 20), "Music:");
		if (GUI.Toggle (new Rect (80, 70, 35, 20), musicon, "On")) {
			   musicon = true;
				musicoff = false;
		}
		if (GUI.Toggle (new Rect (120, 70, 35, 20), musicoff, "Off")) {
			    GetComponent<AudioSource>().enabled=false;
				musicon = false;
				musicoff = true;
	    }
		if (!musicoff&&GetComponent<AudioSource>().enabled){
		}
		if (musicon && !GetComponent<AudioSource> ().enabled) {
			GetComponent<AudioSource>().enabled= true;
		}
		if (Slider >= 5.0f && Slider <= 6.0f) {
			saving (640, 480);
		} 
		if (Slider >= 6.0f && Slider <= 7.0f) {
			saving (710, 436);
		}
		if (Slider >= 7.0f && Slider <= 8.0f) {
			saving(1280,720);
		} 
		if ( Slider >= 8.0f && Slider <= 9.0f) {
			saving(1024,768);		
		}
		if (GUI.Button (exit, word)) {
			GetComponent<GUITexture>().texture = Resources.Load("fronting") as Texture;
			GetComponent<MainMenu>().enabled=true;
			GetComponent<Settings>().enabled=false;
			GetComponent<Authors>().enabled=false;
			GetComponent<AudioSource>().GetComponent<AudioSource>().volume=0.58f;
		}
		GUI.EndGroup ();
	}

	void saving(int weigth, int higth){
	if (GUI.Button ( button, words)){
			if (fullscreen==true){
				PlayerPrefs.SetString("Fullscreen","true");
			} 
			if(fullscreen==false){
				PlayerPrefs.SetString("Fullscreen","false");
			}
			if (musicon==true&&musicoff==false){
				PlayerPrefs.SetString("Musicon","true");
				PlayerPrefs.SetString("Musicoff","false");
			}
			if (musicon==false&&musicoff==true){
				PlayerPrefs.SetString("Musicon","false");
				PlayerPrefs.SetString("Musicoff","true");
			}
			PlayerPrefs.SetFloat("Slider",Slider);
			Screen.SetResolution(weigth, higth, fullscreen);
			GetComponent<GUITexture>().texture = Resources.Load("fronting") as Texture;
			GetComponent<MainMenu>().enabled=true;
			GetComponent<Settings>().enabled=false;
			GetComponent<Authors>().enabled=false;
			GetComponent<AudioSource>().GetComponent<AudioSource>().volume=0.58f;

	}
}
}
