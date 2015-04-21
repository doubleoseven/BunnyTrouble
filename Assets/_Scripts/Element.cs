using UnityEngine;
using System.Collections;

public class Element : MonoBehaviour 
{
	public bool percentage;

	public Sprite[] numberTextures;
	public Sprite [] Vegtables;
	void Start () {
		percentage = Random.value <.20;

		for (int i = 0; i<numberTextures.Length; i++) 
		{
			if(percentage)
			{
				loadTexture(i);
			}
			else 
				loadTexture(Random.Range(0,i));
		}

	

	}
	public void loadTexture(int counter){

			GetComponent<SpriteRenderer> ().sprite = numberTextures [counter];



		}








}
	


