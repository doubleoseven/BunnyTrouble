using UnityEngine;
using System.Collections;

public class winScript : MonoBehaviour {

	public int bunniesToSave = 12;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.instance.bunniesSaved == bunniesToSave) {
			Application.LoadLevel(6);
		}
	
	}
}
