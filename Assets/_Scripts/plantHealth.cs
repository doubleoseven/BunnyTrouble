using UnityEngine;
using System.Collections;

public class plantHealth : MonoBehaviour {
	[SerializeField]
	int currentHealth= 5;
	public void doDamage(int damageValue)
	{
		
		currentHealth -= damageValue;
		
		
		
		// if health is 0 , plant eaten 
		
		if (currentHealth <= 0) {
			
			Destroy(gameObject);
		} 
		
	}
}
