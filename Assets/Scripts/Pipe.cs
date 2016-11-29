using UnityEngine;
using System.Collections;

    public class Pipe : MonoBehaviour {
	// Use this for initialization
	void Start () {
		RandomGeneratePosition ();
	}
	public void RandomGeneratePosition(){
		float pos_y = Random.Range (-0.4f, -0.1f);
		this.transform.localPosition = new Vector3 (this.transform.localPosition.x, pos_y, this.transform.localPosition.z);
		}
	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {
			GetComponent<AudioSource>().Play();
			GameManager._intance.score++;
				}
		}
	void OnGUI(){
		GUILayout.Label ("score:" + GameManager._intance.score);
		}
	// Update is called once per frame
	void Update () {
	
	}
}
