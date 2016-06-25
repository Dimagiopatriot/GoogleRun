using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	public bool buttons=false; 

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
		Screen.lockCursor = true;
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		Doing ();		
		}
	void Doing(){
		if (Input.GetKey (KeyCode.Escape)||GameObject.Find("Player").GetComponent<Impact>().checker==true) {
			GetComponent<AudioSource>().Pause();
			if (buttons == false) {
								Time.timeScale = 0;
								buttons = true;
								Cursor.visible = true;
								Screen.lockCursor = false; 
						}
				}
	}
	void OnGUI(){
		if (buttons == true) {
						if (GUI.Button (new Rect ((Screen.width/2)-20, 20, 130, 40), "Continue")) {
				GetComponent<AudioSource>().Play();
								buttons = false;
								Time.timeScale = 1;
				                Cursor.visible=false;
				Screen.lockCursor=true;
						}
						if (GUI.Button (new Rect ((Screen.width/2)-20, Screen
			                          .height-50, 130, 40), "Main Menu")) {
								Application.LoadLevel ("Menu");		
						}
				}
		}
}
