using UnityEngine;
using System.Collections;

public class soundEffectsManager : MonoBehaviour {

	public AudioSource soundEffect;
	public AudioClip correct;
	public AudioClip wrong;
	public AudioClip buttonClick;
	public AudioClip buttonClick2;
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


	public void playCorrect()
	{
		soundEffect.PlayOneShot (correct);
	}

	public void playWrong()
	{
		soundEffect.PlayOneShot (wrong);
	}

	public void playButtonClick()
	{
		soundEffect.PlayOneShot (buttonClick);
	}

	public void playButtonClick2() 
	{
		soundEffect.PlayOneShot (buttonClick2);
	}
	
}
