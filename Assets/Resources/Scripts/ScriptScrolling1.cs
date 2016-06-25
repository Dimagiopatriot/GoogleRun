using UnityEngine;
using System.Collections;

public class ScriptScrolling1 : MonoBehaviour {
	public Vector2 speed = new Vector2(10,10);
	public Vector2 direction = new Vector2(-1,0);
	public Vector2 movement;
	public int BuffScore=30;
	public GameObject Player;
	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (Player.GetComponent<AddScore> ().Scorying == BuffScore) {
			            speed.x = speed.x+2;
						BuffScore = BuffScore + 30;
				} 
						movement = new Vector2 (speed.x * direction.x, speed.y * direction.y);
						movement *= Time.deltaTime;
						transform.Translate (movement);
				
	}
}
