using UnityEngine;
using System.Collections;

public class plantHealth : MonoBehaviour {

	public int startingHealth = 10;
	public int currentHealth;

	selectTile tile;
	public int scoreValue= 5; 

	bool damaged;

	///public BunnyEating plantCount;

	public bool IsPlantEaten;

	void Start()
	{
		tile = gameObject.transform.GetComponentInParent<selectTile> ();
	}

	void Update()
	{
		if (currentHealth <= 0 && !IsPlantEaten) 
		{	
			Death();
		} 
	}


	public void doDamage(int damageValue)
	{  
		damaged = true;
		currentHealth -= damageValue;
	}

	void Death()
	{
		IsPlantEaten = true;
		ScoreManager.score += scoreValue;
		tile.setVegtablePlanted (false);

		Destroy(gameObject);
	}
}
