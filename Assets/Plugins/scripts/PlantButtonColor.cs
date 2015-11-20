using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(selectPlant))]
public class PlantButtonColor : MonoBehaviour {

	private Button self;
	private selectPlant plantSelect;
	private Color regularColor;
	private Color alphaColor;

	void Start () {
		self = GetComponent<Button> ();
		plantSelect = GetComponent<selectPlant> ();

		regularColor = new Color (1f, 1f, 1f, 1f);
		alphaColor = new Color (1f, 1f, 1f, .5f);
	}
	
	public void changeColor()
	{
		if (plantSelect.IsCurrentSelected()) {
			self.image.color = alphaColor;
		} else 
			self.image.color = regularColor;
	}


}
