using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class ScriptScrolling : MonoBehaviour {
	public Vector2 speed = new Vector2(10,10);
	public Vector2 direction = new Vector2(-1,0);
	public Vector2 movement;
	public bool isLinkedCamera = false;
	public bool isLooping = false;
	private List<Transform> backgroundPart;
	public GameObject Player;
	public int BuffScore =30;
	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		if (isLooping) {
			backgroundPart = new List<Transform>();
			for (int i=0; i<transform.childCount; i++){
				Transform child = transform.GetChild(i);
				if (child.GetComponent<Renderer>()!=null){
					backgroundPart.Add(child);
				}
			}
			backgroundPart=backgroundPart.OrderBy(t=>t.position.x).ToList();
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (Player.GetComponent<AddScore> ().Scorying == BuffScore) {
			            speed.x=speed.x+2;
						BuffScore = BuffScore + 30;
				} 
						movement = new Vector2 (speed.x * direction.x, speed.y * direction.y);
						movement *= Time.deltaTime;
						transform.Translate (movement);
				
		if (isLinkedCamera) {
			Camera.main.transform.Translate(movement);
	}
		if(isLooping) {
			Transform firstChild = backgroundPart.FirstOrDefault();
			if (firstChild != null){
				if (firstChild.position.x < Camera.main.transform.position.x){
					if (firstChild.GetComponent<Renderer>().IsVisibleForm(Camera.main) == false){
						Transform lastChild = backgroundPart.LastOrDefault();
						Vector3 lastPosition = lastChild.transform.position;
						Vector3 lastSize = (lastChild.GetComponent<Renderer>().bounds.max - lastChild.GetComponent<Renderer>().bounds.min);
						firstChild.position = new Vector3(lastPosition.x + lastSize.x, firstChild.position.y, firstChild.position.z);
						backgroundPart.Remove(firstChild);
						backgroundPart.Add(firstChild);
					}
				}
			}
		}
}
}
