using UnityEngine;
using System.Collections;

public class BunnyEating : MonoBehaviour {

	public Animator anim;
    public int count=0;
	//private bunnyHealth bHealth;
	//private plantHealth pHealth;
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

		if (coll.gameObject.tag == "plant") {

			Debug.Log ("Hit");		
			//anim.Play ("eating");
			Debug.Log ("eating1");
			//
			if (Time.time>= nextAttack) {
		
				coll.gameObject.GetComponent<plantHealth> ().doDamage (plantDamage);

				nextAttack = Time.time + attackDelay;
				GetComponent<bunnyHealth> ().doDamage (bunnyDamage);
				GameObject g = GameObject.FindGameObjectWithTag ("plant");
				boolPlant = g.GetComponent<plantHealth> ();
				if (coll.gameObject.GetComponent<plantHealth>().IsPlantEaten == true) {
					coll.gameObject.GetComponent<plantHealth>().IsPlantEaten = false;
					anim.Play ("moving");
					Debug.Log ("moving");
				} 
				else {
					anim.Play ("eating");
					boolPlant.IsPlantEaten = true;
					Debug.Log ("eating2");

				}

				}

			if (GetComponent<bunnyHealth>().isDead){
				anim.Play("AngelBunny");
				Invoke("DestroyObject", 1);
			}
		//Destroy (anim);
		}

	
		}
		
		public void DestroyObject (){
		Destroy (gameObject);
		}
	


}
