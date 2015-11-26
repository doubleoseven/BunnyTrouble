using UnityEngine;
using System.Collections;

public class playAnimation : MonoBehaviour {

	Animator anim;
	int flyin;

	public AnimationClip flyinClip;

	// Use this for initialization
	void Awake() {
		anim = GetComponent<Animator> ();
		flyin = Animator.StringToHash("in");
	}

	public void FlyInAnimation()
	{
		StartCoroutine(Flyinout());
	}

	IEnumerator Flyinout()
	{
		anim.SetBool (flyin, true);
		Invoke ("playWaveSound", flyinClip.length+1);
		yield return new WaitForSeconds(3);
		anim.SetBool (flyin, false);
	}

	public void playWaveSound()
	{
		SoundEffectsManager._instance.playWaveSound (EnemyManager._instance.CurrentWaves);
	}
}
