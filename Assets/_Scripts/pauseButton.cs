using UnityEngine;
using System.Collections;

public class pauseButton : MonoBehaviour {
	public Sprite pl;
	public Sprite pa;

	public void pause()
	{
		GameManager.instance.pause = !GameManager.instance.pause;
	}

	public void changetoPause()
	{
		GetComponent<UnityEngine.UI.Image> ().overrideSprite = pa;
	}

	public void changeToPlay()
	{
		GetComponent<UnityEngine.UI.Image> ().overrideSprite = pl;
	}

	void Update()
	{
		if (GameManager.instance.pause) {
			changeToPlay();
		} else 
			changetoPause();
	}
}
