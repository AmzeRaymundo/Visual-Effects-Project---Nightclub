using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speakers : MonoBehaviour {
	[SerializeField] private AudioSource[] music;

	// Use this for initialization
	void Start () {
		
	}

	void Awake(){
		EventBroadcaster.Instance.AddObserver (EventNames.ON_MUSIC_PLAY, this.playMusic);
		EventBroadcaster.Instance.AddObserver (EventNames.ON_MUSIC_STOP, this.stopMusic);
	}

	void OnDestroy(){
		EventBroadcaster.Instance.RemoveObserver (EventNames.ON_MUSIC_PLAY);
		EventBroadcaster.Instance.RemoveObserver (EventNames.ON_MUSIC_STOP);
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void playMusic(){
		for (int i = 0; i < music.Length; i++) {
			this.music[i].Play();
		}
	}

	public void stopMusic(){
		for (int i = 0; i < music.Length; i++) {
			this.music[i].Stop();
		}
	}

}
