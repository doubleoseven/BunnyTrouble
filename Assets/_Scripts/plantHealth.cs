using UnityEngine;
using System.Collections;

public class plantHealth : MonoBehaviour {
	[SerializeField]
	int currentHealth= 10;
	selectTile tile;

	///public BunnyEating plantCount;

	public bool IsPlantEaten= false ;

	void Start(){
		tile = gameObject.transform.GetComponentInParent<selectTile> ();
	}
	public void doDamage(int damageValue)
	{  

		
		currentHealth -= damageValue;

		
		// if health is 0 , plant eaten 
		
		if (currentHealth <= 0) {	
			IsPlantEaten = true;
			tile.setVegtablePlanted(false);
			//GameManager.instance.count+=1;
			Destroy(gameObject);

		


		} 
		//IsPlantEaten=false;
	}
}
