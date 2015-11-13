using UnityEngine;
using System.Collections;

public class LoadOnClick2 : MonoBehaviour {


	public void LoadScene(int level)
	{   
		SoundEffectsManager._instance.playButtonClick ();
		Application.LoadLevel(level);
	}

	public void quit()
	{
		SoundEffectsManager._instance.playButtonClick ();
		Application.Quit();
	}
 
}
