using UnityEngine;
using System.Collections;

	public class selectNumber : MonoBehaviour {
	public int[] arraysOfNumbersSeleted; 
	int length;
	
	void Start () 
	{
		arraysOfNumbersSeleted = GameManager.instance.getSelectedNumbers ();
		length = arraysOfNumbersSeleted.Length;
	}

	public void SelectNumber()
	{
		if (TileSelected ()) 
		{
			if(NumbersCanBeSelected())
			{
				SoundEffectsManager._instance.playButtonClick();

				
				switch(gameObject.name)
				{
				case "numberOne":
//					Debug.Log (gameObject.name);
					arraysOfNumbersSeleted[GameManager.instance.getCounter()] = 1;
					GameManager.instance.addResult(1);
					break;
				case "numberTwo":
//					Debug.Log (gameObject.name);
					arraysOfNumbersSeleted[GameManager.instance.getCounter()] = 2;
					GameManager.instance.addResult(2);
					break;
				case "numberThree":
//					Debug.Log (gameObject.name);
					arraysOfNumbersSeleted[GameManager.instance.getCounter()] = 3;
					GameManager.instance.addResult(3);
					break;
				case "numberFour":
//					Debug.Log (gameObject.name);
					arraysOfNumbersSeleted[GameManager.instance.getCounter()] = 4;
					GameManager.instance.addResult(4);;
					break;
				 default:
					Debug.Log ("No such number exists");
					break;
				}
				 

				GameManager.instance.setCounter(GameManager.instance.getCounter() +1);
			}
		}
	}
	
	void Update () 
	{
		GameManager.instance.setSelectedNumbers(arraysOfNumbersSeleted);

		if (GameManager.instance.tileSelected != true) {
			Clear(arraysOfNumbersSeleted);
			GameManager.instance.setCounter(0);
			GameManager.instance.setResult(0);
		}
	}

	private void Clear(int[] array)
	{
		for (int i = 0; i<array.Length; i++) 
		{
			array[i] = 0;
		}
	}

	private bool TileSelected()
	{
		return GameManager.instance.tileSelected;
	}
	
	private bool NumbersCanBeSelected()
	{
		return length < 5 && GameManager.instance.getCounter () < 4;
	}

	
}
