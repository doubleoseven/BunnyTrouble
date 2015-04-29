using UnityEngine;
using System.Collections;

public class BunnyEating : MonoBehaviour {

	public Animator anim;
    public int count=0;
	//private bunnyHealth bHealth;
	//private plantHealth pHealth;
	public plantHealth boolPlant;

	void Start(){

		anim = this.GetComponent<Animator>();

	}

	void OnCollisionStay2D(Collision2D coll)
	{
		float last = 0;




		if (coll.gameObject.tag == "plant") {

			Debug.Log ("Hit");		
			anim.Play("eating");;
			//
			if (Time.time - last >= 1) {
		
				coll.gameObject.GetComponent<plantHealth> ().doDamage (1);

				last = Time.time;
				GetComponent<bunnyHealth> ().doDamage (1);
				GameObject g = GameObject.FindGameObjectWithTag ("plant");
				boolPlant = g.GetComponent<plantHealth> ();
				if (boolPlant.IsPlantEaten==true){

					anim.Play ("moving");

					boolPlant.IsPlantEaten=false;}
				}
				else{
				anim.Play ("eating");

					}

			if (GameManager.instance.count == 3)
				//anim.Stop("AngelBunny");
			Destroy(anim);
			}


		
	}





}
