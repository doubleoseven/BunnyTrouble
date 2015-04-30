using UnityEngine;
using System.Collections;

public class musicPlayer : MonoBehaviour
{
	public AudioSource soundEffect;
	public AudioSource bgMusic;
	public static musicPlayer _instance = null;
	
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
		soundEffect.pitch = 5;
		soundEffect.Play ();
	}
	
}