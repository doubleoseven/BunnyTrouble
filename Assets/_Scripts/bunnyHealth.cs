using UnityEngine;
using System.Collections;

public class bunnyHealth : MonoBehaviour
{   
	private SpriteRenderer spriteRenderer; 

	Animator anim;
	[SerializeField]
	int currentHealth= 30; 
   // public bool move= true;
	void Start(){
		anim = GetComponent<Animator> ();
	}

	public bool isDead
	{
		get{return currentHealth<=0;}
	}

	public void doDamage(int damageValue)
	{
		currentHealth -= damageValue;

		if (currentHealth < 0) {
			currentHealth = 0;
		}

		 //if health is 0 , bunny's spell breaks 

		//if (currentHealth <=0) {

			//anim.Play("AngelBunny");
//			move = false;	
//			GetComponent<BunnyEating> ().vanishing();
		
			//Destroy(gameObject);
		
		//} 

	}




}

