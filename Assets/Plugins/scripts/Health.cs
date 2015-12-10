using UnityEngine;
using System.Collections;

public class Health: MonoBehaviour {
	
	protected int currentHealth;
	protected bool dead;

	public virtual void doDamage(int damageValue)
	{
		currentHealth -= damageValue;
	}

	public virtual void death()
	{
		dead = true;
	}

	public bool Dead
	{
		get{ return currentHealth <= 0;}
		set{dead = value;}
	}
}