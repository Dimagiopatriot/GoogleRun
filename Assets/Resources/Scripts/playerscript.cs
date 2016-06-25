using UnityEngine;
using System.Collections;

//behavior script
public class playerscript : MonoBehaviour
{
	// variables

	private static float Jumpspeed=1600f;
	private static float Jumpspeed1=650f;
	public float Timer = 0.6f;
	public float TimerDown;
	public bool isGrounded = false;
	public Transform groundCheck;
	public Transform Player;
	public Transform Platform;
	public int Distance;
	public float groundRadius = 0.3f;
	public LayerMask whatIsGround;
	private Animator anim;
	public bool space_button=false;
	public AudioSource MainTheme;

	void Start()
	{    
		if (PlayerPrefs.GetString ("Musicon") == "true") {
			GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled=true;
			GetComponent<AudioSource>().enabled=true;
		}
		if (PlayerPrefs.GetString ("Musicoff") == "true") {
			GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled=false;
			GetComponent<AudioSource>().enabled=false;
		}
		// animation and timer variables
		anim = GetComponent<Animator>();
		TimerDown = Timer;
		}
	void Jump1 ()
	{ 
		//jump methode
		GetComponent<Rigidbody2D>().AddForce (Vector2.up * Jumpspeed);

	}
	void Jump2 ()
	{
		// g-force methode
	    GetComponent<Rigidbody2D>().AddForce (Vector2.down * Jumpspeed1);
		
	}
    void FixedUpdate ()
	{ 
		isGrounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		//checking grounding of din0
		anim.SetBool ("Ground", isGrounded);
		// taking sped of falling
		anim.SetFloat ("vSpeed", GetComponent<Rigidbody2D>().velocity.y);
		if (isGrounded==false)
						return;
	}

	void Update()
	{   //distance between dino and platform
		Distance = (int)(Vector3.Distance (Player.position, Platform.position));
		//dino jump until timerdown = 0 and isGround is false
		space_button =Input.GetKey (KeyCode.Space);
		if ((Input.GetKeyDown(KeyCode.Space)==true) && (isGrounded == false)) {
				TimerDown = 0;		
			//Jump2();
		}
		if (space_button==true) {
			//GameObject.Find("Main Camera").GetComponent<AudioSource>().Play();
			anim.SetBool ("Ground", false);
			  if (TimerDown > 0) {
				Jump1 ();
				TimerDown -= Time.deltaTime;
			}
			//if (TimerDown == 0 || TimerDown <= 0) {
			//	Jump2 ();
			//}
		}
		if (isGrounded == false) {
			Jump2();
				}
		//Dino can`t jump in air he is falling (timerdown = 0)

		//dino falls when timerdown 0<=
			if (TimerDown == 0 || TimerDown <= 0) {
						Jump2 ();
				}
		//if we dont press space timerdown have timer value
		if (space_button == false) {
						TimerDown = Timer;
			            GameObject.Find("Main Camera").GetComponent<AudioSource>().Play();
				}

				}
}