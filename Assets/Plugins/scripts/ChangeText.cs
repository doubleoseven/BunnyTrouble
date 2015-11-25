using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {

	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	public void ChangeWaveNumber (int wave)
	{
		text.text = "Wave " + wave.ToString();
	}
}
