using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cdjs : MonoBehaviour {
	[SerializeField] private GameObject particleEffect;

	// Use this for initialization
	void Start () {
		
	}

	void Awake(){
		EventBroadcaster.Instance.AddObserver (EventNames.ON_SHOW_PARTICLE_EFFECTS, this.showParticleEffects);
		EventBroadcaster.Instance.AddObserver (EventNames.ON_HIDE_PARTICLE_EFFECTS, this.hideParticleEffects);
	}

	void OnDestroy(){
		EventBroadcaster.Instance.RemoveObserver (EventNames.ON_SHOW_PARTICLE_EFFECTS);
		EventBroadcaster.Instance.RemoveObserver (EventNames.ON_HIDE_PARTICLE_EFFECTS);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void showParticleEffects(){
		this.particleEffect.SetActive (true);
	}

	public void hideParticleEffects(){
		this.particleEffect.SetActive (false);
	}
}
