using UnityEngine;
using System.Collections;

public class BunnyEating : MonoBehaviour {

	private Animator animator;
	//private bunnyHealth bHealth;
	//private plantHealth pHealth;
	void Start(){

		animator = this.GetComponent<Animator>();

	}



	

	void OnCollisionStay2D(Collision2D coll)
	{  	float last = 0;
		Debug.Log("Hit");
		if (coll.gameObject.tag == "plant")
		{
			Debug.Log("Hit the plant");
			animator.SetTrigger("IsEating");
			if (Time.time - last >= 1) 
			{
				coll.gameObject.GetComponent<plantHealth> ().doDamage (1);
				GetComponent<bunnyHealth> ().doDamage (1);
				last = Time.time;
			} 
			plantHealth.instance.plantEaten=true;

			if(plantHealth.instance.plantEaten==true)
			{

				Animator.setFloat (2.0);
			}
		}
    }







}
