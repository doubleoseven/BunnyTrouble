using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {
	public GameObject loadingImage;
	public void LoadScene(int level)
	{   
		soundEffectsManager._instance.playButtonClick ();
		loadingImage.SetActive(true);
		Application.LoadLevel(level);
	}
 
}
