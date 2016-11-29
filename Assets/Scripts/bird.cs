using UnityEngine;
using System.Collections;

public class bird : MonoBehaviour {
	public float timer=0;
	public int frameNumber=10;//每秒帧数
	public int frameCount=0;//计数器

	//public bool  animation=false;
	//public bool  canJump=false;
	void start(){
	//	this.rigidbody.velocity = new Vector3 (5,0,0);
		}

	// Update is called once per frame
	void Update () {
	//	Vector3 vel=this.rigidbody.velocity;
	//	this.rigidbody.velocity = new Vector3 (5, vel.y,vel.z);
		//animation
		if(GameManager._intance.GameState==GameManager.GAMESTATE_PLAYING){
		timer += Time.deltaTime;
			if (timer >= 1.0f/frameNumber) {
				frameCount++;
				timer-=1.0f/frameNumber;
				int frameIndex=frameCount%3;
				this.GetComponent<Renderer>().material.SetTextureOffset("_MainTex",new Vector2(0.33333f*frameIndex,0));

			}
		}
		//controll jump
		if (GameManager._intance.GameState==GameManager.GAMESTATE_PLAYING) {
			if (Input.GetMouseButton (0)) {
				//left mouse button down
				GetComponent<AudioSource>().Play();
				Vector3 vel2 = this.GetComponent<Rigidbody>().velocity;
				this.GetComponent<Rigidbody>().velocity = new Vector3 (vel2.x, 5, vel2.z);
			}
		}
	}
	public void getLife(){
		GetComponent<Rigidbody>().useGravity=true;
		this.GetComponent<Rigidbody>().velocity = new Vector3(2,0,0);

	} 
}
