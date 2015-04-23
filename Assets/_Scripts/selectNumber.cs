using UnityEngine;
using System.Collections;

	public class selectNumber : MonoBehaviour {
	public int currentSelected = 0;
	public int[] arraysOfNumbersSeleted; 
	private int counter = 0;
	public int length;

	//public bool numberSelected = false;
	void Start () {
		arraysOfNumbersSeleted = GameManager.instance.getSelectedNumbers ();
		length = arraysOfNumbersSeleted.Length;
	}
	// Use this for initialization
	private void OnMouseUpAsButton()
	{
		if (gameObject.name == "numberOne") {
			if (arraysOfNumbersSeleted.Length <5) {
				Debug.Log (gameObject.name);
				arraysOfNumbersSeleted[GameManager.instance.getCounter()] = 1;
				GameManager.instance.setCounter(GameManager.instance.getCounter() +1);
			}
		} else if (gameObject.name == "numberTwo") {
			if (arraysOfNumbersSeleted.Length< 5) {
				Debug.Log (gameObject.name);
				arraysOfNumbersSeleted[GameManager.instance.getCounter()] = 2;
				GameManager.instance.setCounter(GameManager.instance.getCounter() +1);
			}
		} else if (gameObject.name == "numberThree") {
			if(arraysOfNumbersSeleted.Length<5){
				Debug.Log (gameObject.name);
				arraysOfNumbersSeleted[GameManager.instance.getCounter()] = 3;
				GameManager.instance.setCounter(GameManager.instance.getCounter() +1);
				}
		} else if (gameObject.name == "numberFour") {
			if(arraysOfNumbersSeleted.Length<5){
				Debug.Log (gameObject.name);
				arraysOfNumbersSeleted[GameManager.instance.getCounter()] = 4;
				GameManager.instance.setCounter(GameManager.instance.getCounter() +1);
				}
		} else
			currentSelected = 0;


		//gameObject.name;
	}

	

	// Update is called once per frame

	void Update () {
		GameManager.instance.setSelectedNumbers(arraysOfNumbersSeleted);

	}


			/*
			if(gameObject.tag ==  "numberone") //GameObject.FindGameObjectWithTag("numberone"))
			{
				Debug.Log("Number one");
			}
			
			else if(gameObject.tag == "numbertwo")
			{
				Debug.Log("Number two");
			}
			
			else if(gameObject.tag ==  "numberthree")
			{
				Debug.Log("Number three");
				
			}
			else
			{
				Debug.Log("Number four");
			}
			*/
		
	
	
}
