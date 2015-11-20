using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Plant : MonoBehaviour {
	
	public float timeUntilAvail = 0.1f;
	selectPlant selectPlantScript;
	Image countDown;

	void Awake()
	{
		countDown = GetComponentsInChildren<Image> () [1];
		selectPlantScript = GetComponent<selectPlant> ();
	}

	void Start()
	{
//		Debug.Log (countDown.name + " " + countDown.fillAmount);
//		StartCoroutine (CountDown());
	}

	public void callCountDown()
	{
		StartCoroutine (CountDown ());
	}

	IEnumerator CountDown()
	{
		selectPlantScript.CanBeSelected = false;
		countDown.fillAmount = 1;
		while (countDown.fillAmount > 0) 
		{
			countDown.fillAmount -= timeUntilAvail *Time.deltaTime;
			yield return null;
		}
		countDown.fillAmount = 0;
		selectPlantScript.CanBeSelected = true;
	}
}
