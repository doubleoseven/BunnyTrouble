using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlantVegtable : MonoBehaviour {

	// The plants that will be used in the level
	public GameObject[] plants;

	private SpriteRenderer spriteRenderer;
	selectTile selectTileScript; 

	void Awake()
	{
		selectTileScript = GetComponent<selectTile> ();
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}

	public void plantVegtable(int index){
		spriteRenderer.color = new Color (1f, 1f, 1f, 0f);
		GameObject vegtable = Instantiate (plants [index], gameObject.transform.position, gameObject.transform.rotation) as GameObject;
		vegtable.transform.SetParent (gameObject.transform);
	}

	void Update(){

		if (selectTileScript.getCurrentSelected ()) 
		{
			if(GameManager.instance.isVegtablePlanted)
			{
				string vegtablePlanted = GameManager.instance.vegtablePlanted;
				switch(vegtablePlanted)
				{
				case "carrot":
					plantVegtable (0);
					break;
				case "turnip":
					plantVegtable(1);
					break;
				case "tomatoes":
					plantVegtable(2);
					break;
				case "pumpkin":
					plantVegtable(3);
					break;
				default:
					print ("no such plant exists");
					break;
				}

				selectTileScript.setCurrentSelected(false);
				selectTileScript.setVegtablePlanted(true);
				GameManager.instance.tileSelected = false;
				GameManager.instance.vegtablePlanted = null;
				GameManager.instance.isVegtablePlanted = false;
			}
		}

		if (TileCanBeSelected()) {
			spriteRenderer.color = new Color (1f, 1f, 1f, 1f);
		}

	}

	bool TileCanBeSelected()
	{
		return selectTileScript.vegtablePlanted != true && selectTileScript.currentSelected!=true;
	}
	 
}
