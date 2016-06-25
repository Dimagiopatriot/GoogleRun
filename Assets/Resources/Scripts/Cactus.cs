using UnityEngine;
using System.Collections;

public class Cactus : MonoBehaviour {
	public float speed = 10f;
	public Vector2 direction;
	private Vector2 movement;
	public Rigidbody2D Cactus1;
	public Transform SpawnDot;
	public float TimerBuf = 0.6f;
	public float Timer;
	//public bool isVisible = true;
	// Use this for initialization
    void Start(){
		Timer = TimerBuf;
	}
	 void Update() { 
		Timer -= Time.deltaTime;
		if (Timer == 0||Timer<=0) {
			Rigidbody2D CactusInst;
			CactusInst = Instantiate(Cactus1, SpawnDot.position, SpawnDot.rotation) as Rigidbody2D;
	    //	transform.Translate(new Vector3 (speed, 0, 0));
			Timer = TimerBuf;
		}
		}

}