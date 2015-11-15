using UnityEngine;
using System.Collections;

public class plantHealth : Health
{
	public int startingHealth = 10;
	public int scoreValue= 5; 
	
	private selectTile tile;
	private bool damaged;

	private  Rigidbody2D rigidbody;
	private SpriteRenderer sprite;


	void Start()
	{
		tile = gameObject.transform.GetComponentInParent<selectTile> ();
		rigidbody = GetComponent<Rigidbody2D> ();
		sprite = gameObject.GetComponent<SpriteRenderer> ();
		currentHealth = startingHealth;
	}

	void Update()
	{
		if (Dead && !dead) 
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
		// This is so that OnCollisionExitIsCalled
		Vector2 moveBy = new Vector2 (Random.Range(0, -Screen.width), Random.Range(0, -Screen.height));
		rigidbody.MovePosition (moveBy);
		sprite.enabled = false;
		Destroy(gameObject, 1);
	}
}
