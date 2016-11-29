using UnityEngine;
using System.Collections;

public class FollowBird : MonoBehaviour {

	private GameObject bird;
	private Transform birdTransform;
	// Use this for initialization
	void Start () {
		bird= GameObject.FindGameObjectWithTag("Player");
		birdTransform = bird.transform;
	
	}
	// Update is called once per frame
	void Update () {
		Vector3 birdPos = birdTransform.position;
		float y = birdPos.y - 2.9418f;
		if(y>2.4f){
			y=2.4f;
		}
		if(y<-2.4f){
			y=-2.4f;
		}
		this.transform.position = new Vector3 (birdPos.x + 5.26024f,y, -10);
	}
}
