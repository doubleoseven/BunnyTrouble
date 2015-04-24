using UnityEngine;
using System.Collections;

	public class GameManager : MonoBehaviour {
		public static GameManager instance = null;
		private BoardManager boardScript;
		public bool tileSelected;
		public bool plantSelected;
		private string plantType;
		private int[] numbersSelected; //Array of numbers selected
		private int counter; //keeps track of the index of numbers selected
		private int result; //
		
		
		private int level = 1;

		// Use this for initialization
		void Start () {
		
		}

		void Awake()
		{
			numbersSelected = new int[] {0, 0, 0, 0};
			counter = 0;
			tileSelected = false;
			plantSelected = false;
			result = 0;
			//ensures there is only one instance of the object
			if (instance == null) {
				instance = this;
			} else if (instance != this)
				Destroy (gameObject);
			DontDestroyOnLoad (gameObject);//Prevents the object from being destroyed 
			boardScript = GetComponent<BoardManager>();
			InitGame ();
		}

		//Getters and Setters!
		public int[] getSelectedNumbers(){
			return numbersSelected;
		}

		public void setSelectedNumbers(int[] array){
			numbersSelected = array;
		}
		public int getCounter(){
			return counter;
		}

		public void setCounter(int value){
			counter = value;
		}

		public void addResult(int number){
			result = result + number;
		}

		public void setResult(int number){
			result = 0;
		}
		
		public int getResult(){
			return result;
		}

		public string getPlantType(){
			return plantType;
		}
		public void setPlantType(string type){
			plantType = type;
		}
			

		void InitGame()
		{
			boardScript.SetupScene (level);
		}
		// Update is called once per frame
		void Update () {
		}
	}

