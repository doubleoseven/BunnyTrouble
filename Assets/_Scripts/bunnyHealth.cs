using UnityEngine;
using System.Collections;

public class bunnyHealth : MonoBehaviour
{   
	private SpriteRenderer spriteRenderer; 

	[SerializeField]
	int currentHealth= 45; 
   // public bool move= true;


	public void doDamage(int damageValue)
	{

		currentHealth -= damageValue;




		 //if health is 0 , bunny's spell breaks 

		if (currentHealth <=0) {

			
//			move = false;	
//			GetComponent<BunnyEating> ().vanishing();
		
			//Destroy(gameObject);
		
		} 

	}




}

