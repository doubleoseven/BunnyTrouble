using UnityEngine;
using System.Collections;

public class BunnyEating : MonoBehaviour {

	public Animator anim;
	//public int count=0;
	//private bunnyHealth bHealth;
	//private plantHealth pHealth;
	//public bool move= true;
	void Start(){

		anim = this.GetComponent<Animator>();

	}



	

	void OnCollisionStay2D(Collision2D coll)
	{  	float last = 0;
		Debug.Log("Hit");



			if (coll.gameObject.tag == "plant") {

				anim.SetTrigger ("IsEating");
			//count=+1;
			if (Time.time - last >= 2) {
					coll.gameObject.GetComponent<plantHealth> ().doDamage (1);

					last = Time.time;
				GetComponent<bunnyHealth> ().doDamage (1);
				} 
		
				
				//bool b= true;
				if (GameObject.Find ("carrot 1").GetComponent<plantHealth> ().IsPlantEaten) {

					anim.SetBool ("plantEaten", true);
				  
				}
		}
		/*
		int curr = GetComponent<bunnyHealth> ().currentHealth;
		if (curr<=0)

		{
			vanishing ();
		}
		*/
    }

	public void vanishing(){

		anim.SetInteger("count",3);
		//move = false;
	}





}
