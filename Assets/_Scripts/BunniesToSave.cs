﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BunniesToSave : MonoBehaviour {

	public static int score;       
	
	
	Text text;                      // Reference to the Text component.
	
	
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		score = 0;
	}
	
	
	void Update ()
	{
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = "Score: " + score;
	}
}
