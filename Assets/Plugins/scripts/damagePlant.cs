using UnityEngine;
using System.Collections;

public class damagePlant : MonoBehaviour {


	public float timeBetweenAttacks = 0.5f;
	public int attackDamage = 1;

	Animator anim;
	AudioSource audio;

	//Refrences to the plant and bunny health scripts
	plantHealth pHealth;
	bunnyHealth bHealth;

	GameObject plant;

	private bool plantInRange;
	float timer;

	void Start()
	{
		audio = GetComponent<AudioSource> ();
		anim = GetComponent<Animator> ();
		bHealth = GetComponent<bunnyHealth> ();
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "plant") 
		{
			Debug.Log ("Colliding with plant!");
			pHealth = coll.gameObject.GetComponent<plantHealth>();
			if(!pHealth.Dead) 
			{
				plantInRange = true;
				anim.SetTrigger("eating");
				audio.Play();
			}
		}
	}

		void OnCollisionExit2D(Collision2D coll)
		{
			if (coll.gameObject.tag == "plant")
			{
				StopColliding();
			}
		}

	
	public void StopColliding()
	{
		Debug.Log ("Not Colliding with plant!");
		plantInRange = false;
		anim.SetTrigger("moving");
		audio.Stop();
	}

	void Update()
	{
		timer += Time.deltaTime;

		if (timer >= timeBetweenAttacks && plantInRange) {
			if (!pHealth.Dead && !bHealth.Dead) { //Bunny can't attack if it's health is 0.
				Attack ();
			}
			else
			{
				//PlantInRange = false;
				StopColliding();
				audio.Stop ();
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

			if (pHealth.Dead) {
				StopColliding ();
			}
		} else 
			StopColliding ();
	}

	public bool PlantInRange
	{
		get{return plantInRange;}
		set{plantInRange = value;}
	}

	public void DestroyObject ()
	{
		Destroy (gameObject);
	}
}
