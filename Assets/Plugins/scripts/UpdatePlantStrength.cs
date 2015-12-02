using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdatePlantStrength : MonoBehaviour {

	Text text;
	public damageBunny damageBunnyScript;

	// Use this for initialization
	void Start () 
	{
		text = GetComponent<Text> ();
		text.text = damageBunnyScript.damage.ToString ();
	}
}
