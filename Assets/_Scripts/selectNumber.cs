using UnityEngine;
using System.Collections;

	public class selectNumber : MonoBehaviour {
	public int[] arraysOfNumbersSeleted; 
	//int length;

	//public bool numberSelected = false;
	void Start () {
		arraysOfNumbersSeleted = GameManager.instance.getSelectedNumbers ();
		//length = arraysOfNumbersSeleted.Length;
	}
	// Use this for initialization
	private void OnMouseUpAsButton()
	{
		if (gameObject.name == "numberOne" && GameManager.instance.tileSelected) {
			if (arraysOfNumbersSeleted.Length <5 && GameManager.instance.getCounter()<4) {
				soundEffectsManager._instance.playButtonClick();
				Debug.Log (gameObject.name);
				arraysOfNumbersSeleted[GameManager.instance.getCounter()] = 1;
				GameManager.instance.addResult(1);
				if(GameManager.instance.getCounter()<4)
					GameManager.instance.setCounter(GameManager.instance.getCounter() +1);
			}
		} 

		else if (gameObject.name == "numberTwo" && GameManager.instance.tileSelected) {
			if (arraysOfNumbersSeleted.Length< 5 && GameManager.instance.getCounter()<4) {
				soundEffectsManager._instance.playButtonClick();
				Debug.Log (gameObject.name);
				arraysOfNumbersSeleted[GameManager.instance.getCounter()] = 2;
				GameManager.instance.addResult(2);
				if(GameManager.instance.getCounter()<4)
					GameManager.instance.setCounter(GameManager.instance.getCounter() +1);
			}
		} 

		else if (gameObject.name == "numberThree" && GameManager.instance.tileSelected) {
			if(arraysOfNumbersSeleted.Length<5 && GameManager.instance.getCounter()<4){
				soundEffectsManager._instance.playButtonClick();
				Debug.Log (gameObject.name);
				arraysOfNumbersSeleted[GameManager.instance.getCounter()] = 3;
				GameManager.instance.addResult(3);
				if(GameManager.instance.getCounter()<4)
					GameManager.instance.setCounter(GameManager.instance.getCounter() +1);
				}
		} 

		else if (gameObject.name == "numberFour" && GameManager.instance.tileSelected) {
			if(arraysOfNumbersSeleted.Length<5 && GameManager.instance.getCounter()<4){
				soundEffectsManager._instance.playButtonClick();
				Debug.Log (gameObject.name);
				arraysOfNumbersSeleted[GameManager.instance.getCounter()] = 4;
				GameManager.instance.addResult(4);
				if(GameManager.instance.getCounter()<4)
					GameManager.instance.setCounter(GameManager.instance.getCounter() +1);
				}
		} 



		//gameObject.name;
	}

	

	// Update is called once per frame

	void Update () {
		GameManager.instance.setSelectedNumbers(arraysOfNumbersSeleted);

		if (GameManager.instance.tileSelected != true) {
			Clear(arraysOfNumbersSeleted);
			GameManager.instance.setCounter(0);
			GameManager.instance.setResult(0);
		}

	}

	private void Clear(int[] array){
		for (int i = 0; i<array.Length; i++) {
			array[i] = 0;
		}
	}


	
}
