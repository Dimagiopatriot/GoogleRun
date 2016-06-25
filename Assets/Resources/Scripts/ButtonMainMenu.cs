using UnityEngine;
using System.Collections;

public class ButtonMainMenu : MonoBehaviour {

	// Use this for initialization
	/*void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}*/
	void OnGUI(){
		if (GUI.Button (new Rect (Screen.width-200, Screen.height-100, 130, 60), "MAIN MENU")) {
						Application.LoadLevel("Menu");
				}
	}
}
