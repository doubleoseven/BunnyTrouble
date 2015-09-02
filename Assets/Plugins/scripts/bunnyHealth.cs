using UnityEngine;
using System.Collections;

public class bunnyHealth : MonoBehaviour
{   
	private SpriteRenderer spriteRenderer; 

	public int startingHealth = 20;
	public int currentHealth;

	public bool dead;

	Animator anim;
   // public bool move= true;


	void Awake()
	{
		anim = GetComponent<Animator> ();
		currentHealth = startingHealth;
	}

	public void doDamage(int damageValue)
	{
		if (isDead)
			return;

		currentHealth -= damageValue;

		if (currentHealth <= 0) 
		{
			Death();
		}

	}

	void Death()
	{
		dead = true;
		GameManager.instance.bunniesSaved+=1;
		anim.SetTrigger("transforming"); 
		Destroy (gameObject, 2f);
	}

	public bool isDead
	{
		get{ return currentHealth <= 0;}
	}





}

