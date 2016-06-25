using UnityEngine;
using System.Collections;

public class Destroying2 : MonoBehaviour {
	public GameObject Player;
	//public float time;
	//public int BuffScore=30;

	// Use this for initialization
	void Start () {
		/*		Player = GameObject.Find ("Player");
				time = 10f;
		}
	void Update(){
		if (Player.GetComponent<AddScore> ().Scorying == BuffScore) {
			time = time+2f;
			BuffScore=BuffScore+30;
		} */
		Destroy (gameObject, 15f);
	}

}
