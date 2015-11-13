using UnityEngine;
using System.Collections;

public class bunnyHealth : Health
{  
	public int startingHealth = 20;

	//To animate when the bunny dies
	Animator anim;
	
	void Awake()
	{
		anim = GetComponent<Animator> ();
		currentHealth = startingHealth;
	}

	public override void doDamage(int damageValue)
	{
		if (Dead)
			return;

		base.doDamage (damageValue);

		if (currentHealth <= 0) 
		{
			death();
		}
	}

	public override void death()
	{
		base.death ();
		GameManager.instance.bunniesSaved+=1;
		anim.SetTrigger("transforming"); 
		Destroy (gameObject, 2f);
	}

}

