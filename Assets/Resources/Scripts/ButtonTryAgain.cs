using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class ButtonTryAgain : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnGUI(){
				if (GUI.Button (new Rect (80, Screen.height-100, 130, 60), "TRY AGAIN!" /*Buttontry*/)){
						Application.LoadLevel("Level");
		}
	}
}
