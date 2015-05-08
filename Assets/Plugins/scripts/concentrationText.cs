using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class concentrationText : MonoBehaviour {


	Text concentration; 
	float beta;
	// Use this for initialization
	void Start () {
		concentration = GetComponent <Text> ();
			
		
	}
	
	// Update is called once per frame
	void Update () {
		beta = DeviceManager.instance.beta * 10;
		concentration.text = Mathf.RoundToInt(beta) + "%";
	}
}
