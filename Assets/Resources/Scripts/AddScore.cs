using UnityEngine;
using System.Collections;

public class AddScore : MonoBehaviour {
	public GameObject Player;
	public float Timer=1.0f;
	public float TimerDown;
	public int Scorying = 0;

	// Use this for initialization
	void Start () {
		TimerDown = Timer;
	}
	
	// Update is called once per frame
	void Update () {
		TimerDown -= Time.deltaTime;
	    if (TimerDown<=0) {
			Scorying=Scorying+1;
			TimerDown = Timer;
		}
		Debug.Log (TimerDown);
	}
}
