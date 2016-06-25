using UnityEngine;
using System.Collections;

public class Impact : MonoBehaviour {
	public bool checker=false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.layer == 9) {
			checker=true;
			Application.LoadLevel("DieScreen");
		}
	}
}
