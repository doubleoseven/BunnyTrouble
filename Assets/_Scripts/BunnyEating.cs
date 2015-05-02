﻿using UnityEngine;
using System.Collections;

public class BunnyEating : MonoBehaviour {

	public Animator anim;
    public int count=0;
	public plantHealth boolPlant;
	[SerializeField] 
	int bunnyDamage = 1;
	[SerializeField] 
	int plantDamage = 1;
	[SerializeField]
	float attackDelay = 10.0f;

	void Start(){

		anim = this.GetComponent<Animator>();

	}

	void OnCollisionStay2D(Collision2D coll)
	{
		float nextAttack = -1.0f;

		if (coll.gameObject.tag == "plant" && Time.time >= nextAttack) {

			Debug.Log ("Hit");		
			//anim.Play ("eating");
			Debug.Log ("eating1");
			//
			coll.gameObject.GetComponent<plantHealth> ().doDamage (plantDamage);
			GetComponent<bunnyHealth> ().doDamage (bunnyDamage);

			nextAttack = Time.time + attackDelay;
			
			if (coll.gameObject.GetComponent<plantHealth> ().IsPlantEaten == true) {
				coll.gameObject.GetComponent<plantHealth> ().IsPlantEaten = false;
				anim.Play ("moving");
				Debug.Log ("moving");
			} else {
				anim.Play ("eating");
				Debug.Log ("eating2");
				//Destroy (anim);
			}

			if (GetComponent<bunnyHealth> ().isDead) {
				anim.Play ("AngelBunny");
				Invoke ("DestroyObject", 1);
			}
		}
	}

	void OnCollisionExit(){
		anim.Play ("moving");
	}
		
		
	public void DestroyObject (){
		Destroy (gameObject);
	}
	


}
