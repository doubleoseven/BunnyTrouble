using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	public static DontDestroy _instance = null;
	void Start()
	{
		if(!_instance)
			_instance = this ;
		//otherwise, if we do, kill this thing
		else
			Destroy(this.gameObject) ;
		//Causes UI object not to be destroyed when loading a new scene. If you want it to be destroyed, destroy it manually via script.
		DontDestroyOnLoad(this.gameObject);
	}

	

}
