using UnityEngine;
using System.Collections;

public class damageBunny : MonoBehaviour {

	public int damage = 1;
	public float timeBetweenDamage = 0.15f;

	public bool bunnyInRange;
	float timer;

	plantHealth pHealth;
	bunnyHealth bHealth;
	// Use this for initialization
	void Awake() 
	{
	
	}

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
			Debug.Log ("Not Colliding with bunny!");
			bunnyInRange = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (timer >= timeBetweenDamage && bunnyInRange) {
			if (!bHealth.Dead) {
				Attack ();
			} else
				bunnyInRange = false;
		}
	}

	void Attack()
	{
		timer = 0f;
		if (!bHealth.Dead) {
			bHealth.doDamage (damage);
		} else 
			bunnyInRange = false;
	}
}
