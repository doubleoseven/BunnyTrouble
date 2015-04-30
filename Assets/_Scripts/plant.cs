using UnityEngine;
using System.Collections;

public class plant : MonoBehaviour {

	selectTile tile;


	// Use this for initialization
	void Start () {
		tile = GetComponent<selectTile> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Plant()
	{
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

}
