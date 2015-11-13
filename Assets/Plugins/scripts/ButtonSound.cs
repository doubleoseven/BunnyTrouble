using UnityEngine;
using System.Collections;

public class ButtonSound : MonoBehaviour {
	
	public AudioSource audio;
	public AudioClip ButtonClick;
	
	public void clicksound(){

		audio.PlayOneShot (ButtonClick);
	}
}