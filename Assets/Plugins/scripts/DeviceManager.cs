using UnityEngine;
using System.Collections;

public class DeviceManager : MonoBehaviour {
	public static DeviceManager instance = null;

	public float previousBeta;
	public float beta;
	public bool device;

	// Use this for initialization
	void Awake () {
		 previousBeta = 0;
		 beta = 0;
	
		if (instance == null) {
			instance = this;
		} else if (instance != this)
			Destroy (gameObject);
		DontDestroyOnLoad (gameObject);//Prevents the object from being destroyed 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
