using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {
	public GameObject loadingImage;
	public void LoadScene(int level)
	{   
		SoundEffectsManager._instance.playButtonClick ();
		loadingImage.SetActive(true);
		Application.LoadLevel(level);
	}
 
}
