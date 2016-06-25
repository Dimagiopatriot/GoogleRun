using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public GUIStyle Scores;
	public GameObject Player;
	public int Buff;
	public string writescore;

	void Start (){
		Player = GameObject.Find ("Player");
	}

	void OnGUI () {
		GUI.Label (new Rect (10, 10, 1000, 1000), "Scores: "+writescore, Scores); 	
	}
	void Update(){
		Buff = Player.GetComponent<AddScore> ().Scorying;
		writescore=Buff.ToString();
		try{
		System.IO.File.WriteAllText (@"C:\Scores.txt", writescore);
		}catch(System.IO.FileNotFoundException e){
						System.IO.File.Create (@"C:\Scores.txt");
						System.IO.File.WriteAllText (@"C:\Scores.txt", writescore);
		}catch(System.UnauthorizedAccessException e){
			e.StackTrace.ToString();
				}
		OnGUI ();
	}// Use this for initialization

}
