using UnityEngine;
using System.Collections;

public class LoadOnClick2 : MonoBehaviour {


	public void LoadScene(int level)
	{   
		soundEffectsManager._instance.playButtonClick ();
		Application.LoadLevel(level);
	}

	public void quit()
	{
		soundEffectsManager._instance.playButtonClick ();
		Application.Quit();
	}
 
}
