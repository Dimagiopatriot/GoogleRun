using UnityEngine;
using System.Collections;

public class LogoSettings : MonoBehaviour {
	public float DelayTime = 6.7f;
	private float TimerDown;
	private float BlindAlpha;

	// Use this for initialization
	void Start () {
		TimerDown = DelayTime;
		BlindAlpha = 0;
	}
	
	// Update is called once per frame
	void Update () {
		TimerDown = TimerDown - Time.fixedDeltaTime;
		GetComponent<GUITexture> ().pixelInset = new Rect (Screen.width/2, Screen.height/2,0,0);
		BlindAlpha += 0.002f;
		GetComponent<GUITexture> ().color = new Color (255,255,255,BlindAlpha);
		if (TimerDown <= 0) {
						Application.LoadLevel ("Menu");
				}
		}
}
