using UnityEngine;
using System.Collections;

public class plantHealth : MonoBehaviour {
	[SerializeField]
	int currentHealth= 10;

	///public BunnyEating plantCount;

	public bool IsPlantEaten= false ;

	public void doDamage(int damageValue)
	{  

		
		currentHealth -= damageValue;

		
		// if health is 0 , plant eaten 
		
		if (currentHealth <= 0) {	
			IsPlantEaten=true;
			GameManager.instance.count+=1;
		
			Destroy(gameObject);

		


		} 
		//IsPlantEaten=false;
	}
}
