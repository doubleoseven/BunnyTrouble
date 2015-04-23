using UnityEngine;
using System.Collections;

	public class GameManager : MonoBehaviour {
		public static GameManager instance = null;
		private BoardManager boardScript;
		public bool tileSelected;

		private int level = 1;

		// Use this for initialization
		void Start () {
		
		}

		void Awake()
		{
			tileSelected = false;
			//ensures there is only one instance of the object
			if (instance == null) {
				instance = this;
			} else if (instance != this)
				Destroy (gameObject);
			DontDestroyOnLoad (gameObject);//Prevents the object from being destroyed 
			boardScript = GetComponent<BoardManager>();
			InitGame ();
		}

		void InitGame()
		{
			boardScript.SetupScene (level);
		}
		// Update is called once per frame
		void Update () {
		
		}
	}

