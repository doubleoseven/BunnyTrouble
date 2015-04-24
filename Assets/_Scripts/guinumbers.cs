using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class guinumbers : MonoBehaviour {
	
	private int[] numbersSelected;
	[SerializeField]
	Text firstOperand;
	[SerializeField]
	Text secondOperand;
	[SerializeField]
	Text thirdOperand;
	[SerializeField]
	Text fourthOperand;
	[SerializeField]
	Text result;


	// Use this for initialization
	void Start () {
		numbersSelected = GameManager.instance.getSelectedNumbers();
		firstOperand = firstOperand.GetComponent<Text> ();
		secondOperand = secondOperand.GetComponent<Text> ();
		thirdOperand = thirdOperand.GetComponent<Text> ();
		fourthOperand = fourthOperand.GetComponent<Text> ();
		result = result.GetComponent<Text> ();
	}

	public void OnGUI(){
		firstOperand.text = numbersSelected [0].ToString ();
		secondOperand.text = numbersSelected [1].ToString ();
		thirdOperand.text = numbersSelected [2].ToString ();
		fourthOperand.text = numbersSelected [3].ToString ();
		result.text = GameManager.instance.getResult().ToString ();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
