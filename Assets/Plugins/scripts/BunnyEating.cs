using UnityEngine;
using System.Collections;

public class BunnyEating : MonoBehaviour {


	public float timeBetweenAttacks = 0.5f;
	public int attackDamage = 1;

	Animator anim;
	//GameObject player;

	plantHealth pHealth;
	bunnyHealth bHealth;

	public bool plantInRange;
	float timer;

//    public int count=0;
//	public plantHealth boolPlant;
//	[SerializeField] 
//	int bunnyDamage = 1;
//	[SerializeField] 
//	int plantDamage = 1;
//	[SerializeField]
//	float attackDelay = 10.0f;

	void Start()
	{

		anim = GetComponent<Animator> ();
		bHealth = GetComponent<bunnyHealth> ();
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "plant") 
		{
			pHealth = coll.gameObject.GetComponent<plantHealth>();
			plantInRange = true;
		}
	}

	void OnCollisionExit2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "plant")
		{
			plantInRange = false;
			anim.SetTrigger("moving");
		}
	}

//	void OnCollisionStay2D(Collision2D coll)
//	{
//		float nextAttack = -1.0f;
//
//		if (coll.gameObject.tag == "plant" && Time.time >= nextAttack) {
//
//			Debug.Log ("Hit");		
//			//anim.Play ("eating");
//			Debug.Log ("eating1");
//			//
//			if(!GetComponent<bunnyHealth>().isDead)
//			{
//			coll.gameObject.GetComponent<plantHealth> ().doDamage (plantDamage);
//			}
//			GetComponent<bunnyHealth> ().doDamage (bunnyDamage);
//
//			nextAttack = Time.time + attackDelay;
//			
//			if (coll.gameObject.GetComponent<plantHealth> ().IsPlantEaten == true) {
//				coll.gameObject.GetComponent<plantHealth> ().IsPlantEaten = false;
//				anim.Play ("moving");
//				Debug.Log ("moving");
//			} else {
//				anim.Play ("eating");
//				Debug.Log ("eating2");
//				//Destroy (anim);
//			}
//
//			if (GetComponent<bunnyHealth> ().isDead) {
//				GameManager.instance.bunniesSaved+=1;
//				anim.Play ("AngelBunny");
//				Invoke ("DestroyObject", 1);
//			}
//		}
//	}

	void Update()
	{
		timer += Time.deltaTime;

		if (timer >= timeBetweenAttacks && plantInRange && pHealth.currentHealth > 0 && !bHealth.dead) {
			Attack ();
			anim.SetTrigger ("eating");
		} else 
			anim.SetTrigger ("moving");
	}

	void Attack()
	{
		timer = 0f;
		if (pHealth.currentHealth > 0) 
		{
			pHealth.doDamage(attackDamage);
		}
	}


	public void DestroyObject ()
	{
		Destroy (gameObject);
	}
}
