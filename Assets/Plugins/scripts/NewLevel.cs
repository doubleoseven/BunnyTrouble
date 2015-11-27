using UnityEngine;
using System.Collections;

public class NewLevel : MonoBehaviour {

	private ShowPanels showPanels;
	private bool newLevel;								
	private StartOptions startScript;		

	void Awake()
	{
		//Get a component reference to ShowPanels attached to this object, store in showPanels variable
		showPanels = GetComponent<ShowPanels> ();
		//Get a component reference to StartButton attached to this object, store in startScript variable
		startScript = GetComponent<StartOptions> ();
	}

	public void ShowNewLevelScreen()
	{
		newLevel = true;

		Time.timeScale = 0;

		showPanels.ShowNewLevelPanel ();
	}

	public void HideNewLevelScreen()
	{
		newLevel = false;

		Time.timeScale = 1;

		showPanels.HideNewLevelPanel ();
	}
}

