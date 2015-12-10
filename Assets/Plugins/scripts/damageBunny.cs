using UnityEngine;
using System.Collections;

public class damageBunny : MonoBehaviour 
{

	public int damage = 1;
	public float timeBetweenDamage = 0.15f;

	public bool bunnyInRange;
	float timer;

	plantHealth pHealth;
	bunnyHealth bHealth;


	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "enemy") 
		{
			Debug.Log ("Colliding with bunny!");
			bHealth = coll.gameObject.GetComponent<bunnyHealth>();
			bunnyInRange = true;
		}
	}

	void OnCollisionExit2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "enemy") 
		{
			StopColliding();
		}
	}


	//Put back the ONCollisionExit2D etc

	public void StopColliding()
	{
		Debug.Log ("Not Colliding with bunny");
		bunnyInRange = false;
	}
	

	void Update () 
	{
		timer += Time.deltaTime;

		if (timer >= timeBetweenDamage && bunnyInRange) 
		{
			if (!bHealth.Dead) 
			{
				Attack ();
			} else
			{
				StopColliding();
			}
				
		}
	}

	void Attack()
	{
		timer = 0f;

		if (!bHealth.Dead) {
			// Deliver Damage
			bHealth.doDamage (damage);

			// Check if bunny has "died"
			if (bHealth.Dead) {
				StopColliding ();
			}
		} else
			StopColliding ();
	}
}
