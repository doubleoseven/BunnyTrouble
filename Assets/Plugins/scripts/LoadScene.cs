using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

		
	 public AnimationClip fadeColorAnimationClip;		//Animation clip fading to color (black default) when changing scenes
	 public AnimationClip fadeAlphaAnimationClip;		//Animation clip fading out UI elements alpha
	 public Animator animColorFade; 					//Reference to animator which will fade to and from black when starting game.
	
	private ShowPanels showPanels;	
	private StartOptions startOptions;
	// Use this for initialization
	void Awake()
	{
		//Get a reference to ShowPanels attached to UI object
		showPanels = GetComponent<ShowPanels> ();
		startOptions = GetComponent<StartOptions> ();
	}
	
	public void LoadSpecificScene(int level)
	{
//		Invoke ("LoadDelayed", fadeColorAnimationClip.length * .5f);
		StartCoroutine (LoadDelayed (level, fadeColorAnimationClip.length * .5f));

		animColorFade.SetTrigger ("fade");
		animColorFade.SetBool("faded", true);

	}

	IEnumerator LoadDelayed(int level, float delayTime)
	{
		yield return new WaitForSeconds(delayTime);
		//Pause button now works if escape is pressed since we are no longer in Main menu.
		startOptions.inMainMenu = false;
		
		//Hide the main menu UI element
		showPanels.HideMenu ();
		
		//Load the selected scene, by scene index number in build settings
		Application.LoadLevel (level);
	}
}
