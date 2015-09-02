using UnityEngine;
using System.Collections;

public class plantDamage : MonoBehaviour {

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
			bHealth = coll.gameObject.GetComponent<bunnyHealth>();
			bunnyInRange = true;
		}
	}

	void OnCollisionExit2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "enemy") 
		{
			bunnyInRange = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (timer >= timeBetweenDamage && bunnyInRange && bHealth.currentHealth > 0) 
		{
			Attack();
		}
	}

	void Attack()
	{
		timer = 0f;
		if(bHealth.currentHealth > 0)
		{
			bHealth.doDamage(damage);
		}
	}
}
