using UnityEngine;
using System.Collections;

public class Element : MonoBehaviour 
{
	public bool numberFive, numberSix, numberSeven;

	public Sprite[] numberTextures;
	void Start () {
		numberFive = Random.value < .30;
		numberSix = Random.value < .20;
		numberSeven = Random.value < .20;
	
		if (numberFive) {

			loadTexture (0);
		} else if (numberSix) {
			loadTexture (1);

		} else if (numberSeven) {

			loadTexture (2);
		} else
			loadTexture (3);

	

	}
	public void loadTexture(int counter){

			GetComponent<SpriteRenderer> ().sprite = numberTextures [counter];



		}








}
	


