using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSPlayer : MonoBehaviour {
	[SerializeField] private Camera mainCam;
	private bool isPlaying = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = mainCam.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if(Physics.Raycast(ray, out hit) && hit.collider.name.Contains("DJPlayer")){
				print ("HIT!!!!!!!!!!!!!!!!!!!!!");
				if (!this.isPlaying) {
					EventBroadcaster.Instance.PostEvent (EventNames.ON_MUSIC_PLAY);
					EventBroadcaster.Instance.PostEvent (EventNames.ON_VIDEO_PLAY);
					EventBroadcaster.Instance.PostEvent (EventNames.ON_HIDE_PARTICLE_EFFECTS);
					this.isPlaying = true;
				} 
				else {
					EventBroadcaster.Instance.PostEvent (EventNames.ON_MUSIC_STOP);
					EventBroadcaster.Instance.PostEvent (EventNames.ON_VIDEO_STOP);
					EventBroadcaster.Instance.PostEvent (EventNames.ON_SHOW_PARTICLE_EFFECTS);
					this.isPlaying = false;
				}
			}
		}
	}
}
