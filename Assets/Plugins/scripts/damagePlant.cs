using UnityEngine;
using System.Collections;

public class damagePlant : MonoBehaviour {


	public float timeBetweenAttacks = 0.5f;
	public int attackDamage = 1;

	Animator anim;

	//Refrences to the plant and bunny health scripts
	plantHealth pHealth;
	bunnyHealth bHealth;

	GameObject plant;

	private bool plantInRange;
	float timer;

	void Start()
	{

		anim = GetComponent<Animator> ();
		bHealth = GetComponent<bunnyHealth> ();
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "plant") 
		{
			Debug.Log ("Colliding with plant!");
			pHealth = coll.gameObject.GetComponent<plantHealth>();
			plantInRange = true;
			anim.SetTrigger("eating");
		}
	}

	void OnCollisionExit2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "plant")
		{
			Debug.Log ("Not Colliding with plant!");
			plantInRange = false;
			anim.SetTrigger("moving");
		}
	}

	void Update()
	{
		timer += Time.deltaTime;

		if (timer >= timeBetweenAttacks && plantInRange) {
			if (!pHealth.Dead && !bHealth.Dead) { //Bunny can't attack if it's health is 0.
				Attack ();
			}
		}
	}

	void Attack()
	{
		timer = 0f;
		if (!pHealth.Dead) {
			Debug.Log (pHealth.Dead);
			pHealth.doDamage (attackDamage);
			//anim.SetTrigger ("eating");
			Debug.Log ("Damaged plant!");
		} else {
			//anim.SetTrigger ("moving");
			PlantInRange = false;
		}
	}

	public bool PlantInRange
	{
		get{return plantInRange;}
		set{PlantInRange = value;}
	}

	public void DestroyObject ()
	{
		Destroy (gameObject);
	}
}
