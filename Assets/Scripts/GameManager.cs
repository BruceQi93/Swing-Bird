using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	//define game state
	public static int GAMESTATE_MENU	=0;
	public static int GAMESTATE_PLAYING	=1;
	public static int GAMESTATE_END		=2;

	public Transform firstBg;
	public int score=0;
	public int GameState =GAMESTATE_MENU ;
	public static GameManager _intance;
	private GameObject bird;

	void Awake(){
		_intance = this;
		bird = GameObject.FindGameObjectWithTag("Player");
	}
	void Update(){
		if (GameState == GameManager.GAMESTATE_MENU) {
			if(Input.GetMouseButtonDown(0)){
				GameState =GAMESTATE_PLAYING;
				bird.GetComponent<Rigidbody>().useGravity=true;
				bird.SendMessage("getLife");
			}
		}
		if (GameState == GameManager.GAMESTATE_END) {
			GameMenu._instance.gameObject.SetActive(true);
			GameMenu._instance.UpdateScore(score);
		}
	}
}
