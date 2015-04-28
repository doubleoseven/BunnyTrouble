using UnityEngine;
using System.Collections;

public class bunnyHealth : MonoBehaviour
{   
	private SpriteRenderer spriteRenderer; 
	public Sprite evilBunny;
	public Sprite cuteBunny;
	[SerializeField]
	int currentHealth= 3; 
	void start()
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
		/*
		if (spriteRenderer == null) 
		{
			//spriteRenderer.Sprite==evilBunny;
		}




*/




	}
	public void doDamage(int damageValue)
	{

		currentHealth -= damageValue;



		 //if health is 0 , bunny's speel breaks 

		if (currentHealth <= 0) {

			changetheSprite();
		} 

	}

	void changetheSprite()
	{
		if (spriteRenderer.sprite == evilBunny) 
		{
			gameObject.GetComponent<SpriteRenderer>().sprite = cuteBunny;
		}

	}


}

