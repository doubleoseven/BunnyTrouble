using UnityEngine;
using System.Collections;

public class winGame : MonoBehaviour {
	public bool win = false;
	LoadOnClick2 load;
	public int bunniesToSave = 12;
	// Use this for initialization
	void Start () {
		load = GetComponent<LoadOnClick2> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(GameManager.instance.bunniesSaved == bunniesToSave){
			win = true;
			Application.LoadLevel(5);
		}
	
	}
}
