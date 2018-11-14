using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TV : MonoBehaviour {
	[SerializeField] private VideoPlayer vid;

	// Use this for initialization
	void Start () {
		
	}

	void Awake(){
		EventBroadcaster.Instance.AddObserver (EventNames.ON_VIDEO_PLAY, this.playVideo);
		EventBroadcaster.Instance.AddObserver (EventNames.ON_VIDEO_STOP, this.stopVideo);
	}

	void OnDestroy(){
		EventBroadcaster.Instance.RemoveObserver (EventNames.ON_VIDEO_PLAY);
		EventBroadcaster.Instance.RemoveObserver (EventNames.ON_VIDEO_STOP);
	}

	// Update is called once per frame
	void Update () {
		
	}

	void playVideo(){
		this.vid.Play();
	}

	void stopVideo(){
		this.vid.Stop();
	}
}
