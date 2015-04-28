using UnityEngine;
using System.Collections;

public class BunnyEating : MonoBehaviour {

	private Animator animator;
	void Start(){

		animator = this.GetComponent<Animator>();
	}
	float last = 0;
	void OnCollisionStay2D(Collision2D coll)
	{  
		if (coll.gameObject.tag == "plant")
		{
			animator.SetTrigger("IsEating");
			coll.gameObject.GetComponent<bunnyHealth> ().doDamage (1);

		}
	
		if (Time.time - last >= 1) 
		{
			coll.gameObject.GetComponent<plantHealth> ().doDamage (1);
	
			last = Time.time;
		}




	}
	
	

}
