using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	private Animator animator;

	void Start(){
		animator = GetComponent<Animator> ();	
	}

	void Update(){
	
	}

	void OnTriggerEnter(Collider other){
		if (other.transform.tag == "Player") {
			print ("Triggered");
			animator.SetBool ("open", true);
//			GetComponent<Animation>().Play ("DoorOpen");
		}
	}

	void OnTriggerExit(Collider Player){
		if (Player.transform.tag == "Player") {
			print ("Trigger Exited");
//			animator.SetBool ("open", true);
		//GetComponent<Animation>().Play ("DoorClose");
		}
	}

//	IEnumerator ExitTimer(){
//		yield return new WaitForSeconds (5);
//		GetComponent<Animation>().Play ("DoorClose");
//	}
}
