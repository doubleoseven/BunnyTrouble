﻿using UnityEngine;
using System.Collections;

public class plantButton : MonoBehaviour {
	Element elem;

	void Start () {
		elem = this.GetComponent<Element> () as Element;
	}

	public void plant(){

		if (GameManager.instance.tileSelected) {
			if(GameManager.instance.plantSelected){
				if(GameManager.instance.getResult() == GameManager.instance.getTileSelectedValue()){
					if(GameManager.instance.getPlantType() == "carrot"){
						GameManager.instance.carrotPlanted = true;
						//vegtablePlanted = true;
						//GameManager.instance.tileSelected = false;
					}
					else if(GameManager.instance.getPlantType() == "turnip"){
						GameManager.instance.turnipPlanted = true;
						//musicPlayer._instance.PlaySingle(plant);
					}
				} else {
					Debug.Log ("Result not correct");
					//musicPlayer._instance.PlaySingle(wrong);
					GameManager.instance.tileSelected = false;
				}
			} else Debug.Log("Plant not selected");
		} else Debug.Log ("Tile not selected");
	}
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
	
	}
}
