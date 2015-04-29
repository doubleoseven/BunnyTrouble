using UnityEngine;
using System.Collections;

public class plantHealth : MonoBehaviour {
	[SerializeField]
	int currentHealth= 10;

	///public BunnyEating plantCount;

	public bool IsPlantEaten = false;

	public void doDamage(int damageValue)
	{  

		
		currentHealth -= damageValue;

		
		// if health is 0 , plant eaten 
		
		if (currentHealth <= 0) {	
			GameManager.instance.count+=1;
			IsPlantEaten=true;
			Destroy(gameObject);

		


		} 
		//IsPlantEaten=false;
	}
}
