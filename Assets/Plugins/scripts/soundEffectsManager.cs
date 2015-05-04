using UnityEngine;
using System.Collections;

public class soundEffectsManager : MonoBehaviour {

	AudioSource soundEffect;
	public AudioClip correct;
	public AudioClip wrong;
	public static soundEffectsManager _instance = null;
	// Use this for initialization
	void Start () {
		soundEffect = GetComponent<AudioSource> ();
	}

	void Awake()
	{
		//if we don't have an [_instance] set yet
		if(!_instance)
			_instance = this ;
		//otherwise, if we do, kill this thing
		else
			Destroy(this.gameObject) ;
		
		
		DontDestroyOnLoad(this.gameObject) ;
	}
	
	public void PlaySingle(AudioClip clip)
	{
		soundEffect.clip = clip;
		soundEffect.pitch = 10;
		soundEffect.Play ();
		Debug.Log ("Played!");
	}

	public void playCorrect(){
		soundEffect.PlayOneShot (correct);
	}

	public void playWrong(){
		soundEffect.PlayOneShot (wrong);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
