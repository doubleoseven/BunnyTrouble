using UnityEngine;
using System.Collections;

public class selectPlant : MonoBehaviour {
	public Sprite overlay;

	private void OnMouseUpAsButton(){
		//GetComponent<SpriteRenderer> ().sprite = overlay;
		GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, .5f);
		Debug.Log (gameObject.name);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
