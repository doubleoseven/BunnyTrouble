using UnityEngine;
using System.Collections;

public class playAnimation : MonoBehaviour {

	Animator anim;
	int flyin;

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
		yield return new WaitForSeconds(2);
		anim.SetBool (flyin, false);
	}
}
