using UnityEngine;
using System.Collections;

public class bunnyHealth : MonoBehaviour
{   
	private SpriteRenderer spriteRenderer; 

	[SerializeField]
	int currentHealth = 30;
	public bool dead = false;
   // public bool move= true;


	public void doDamage(int damageValue)
	{

		currentHealth -= damageValue;

		if (currentHealth < 0)
			currentHealth = 0;

	 //if health is 0 , bunny's spell breaks 
			
//			move = false;	
//			GetComponent<BunnyEating> ().vanishing();
		
			//Destroy(gameObject)

	}

	public bool isDead{
		get{ return currentHealth <= 0;}
	}

	void Update(){
		if (currentHealth <= 0) {
			dead = true;
		}	
	}




}

