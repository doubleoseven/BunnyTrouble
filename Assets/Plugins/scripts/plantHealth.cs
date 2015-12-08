using UnityEngine;
using System.Collections;

public class plantHealth : Health
{
	public int startingHealth = 10;
	public int scoreValue= 5; 
	
	private selectTile tile;
	private bool damaged;

	private  Rigidbody2D rigidbody;
	private BoxCollider2D collider;
	private SpriteRenderer sprite;


	void Start()
	{
		tile = gameObject.transform.GetComponentInParent<selectTile> ();
		rigidbody = GetComponent<Rigidbody2D> ();
		sprite = gameObject.GetComponent<SpriteRenderer> ();
		collider = GetComponent<BoxCollider2D> ();
		currentHealth = startingHealth;
	}

	void Update()
	{
		if (Dead) 
		{	
			death();
		} 
	}


	public override void doDamage(int damageValue)
	{  
		base.doDamage (damageValue);
	}

	public override void death()
	{
		base.death ();
		ScoreManager.score += scoreValue;
		tile.setVegtablePlanted (false);
		Destroy (gameObject);
	}

	public void Destroy(GameObject gameObject)
	{
		// Allow the bunny to keep walking
		collider.enabled = false;
		// Hide the sprite 
		sprite.enabled = false;

		Destroy(gameObject, 1);
	}
}
