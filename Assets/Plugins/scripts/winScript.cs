using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class winScript : MonoBehaviour {

	public int bunniesToSave = 9;
	public int bunniesLeft; 
	public Animator anim;
	public AnimationClip poof;
	Text text;  

	void Awake () {
		text = GetComponent <Text> ();
		bunniesLeft = 9;
	}
	
	// Update is called once per frame
	void Update () {
		//Display the number of bunnies on screen.
		bunniesLeft = bunniesToSave - GameManager.instance.bunniesSaved;
		text.text = " " + bunniesLeft;

		if (bunniesLeft <= 0) {

			SoundEffectsManager._instance.playFireWorks();
			LoadLevel();
		}
	
	}


	void LoadLevel()
	{
		Application.LoadLevel (6);
	}

//	void OnLevelWasLoaded(int level)
//	{
//		if (level == 6) 
//		{
//			SoundEffectsManager._instance.playFireWorks();
//		}
//	}
}
