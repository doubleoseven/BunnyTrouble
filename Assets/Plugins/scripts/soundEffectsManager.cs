using UnityEngine;
using System.Collections;

public class SoundEffectsManager : MonoBehaviour {

	public AudioSource soundEffect;

	public AudioClip correct;
	public AudioClip wrong;
	public AudioClip buttonClick;
	public AudioClip buttonClick2;
	public AudioClip win;
	public AudioClip lose;
	public AudioClip[] waves;

	public static SoundEffectsManager _instance = null;
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

	public void playFireWorks()
	{
		soundEffect.PlayOneShot (win);
	}

	public void playGameOver()
	{
		soundEffect.PlayOneShot (lose);
	}

	public void playWaveSound(int currentWave)
	{
		switch (currentWave) 
		{
			case 0:
				soundEffect.PlayOneShot(waves[0]);
				break;
			case 1:
				soundEffect.PlayOneShot(waves[1]);
				break;
			case 2:
				soundEffect.PlayOneShot(waves[2]);
				break;
			default:
				Debug.Log ("No such wave");
				break;
		}
	}

}
