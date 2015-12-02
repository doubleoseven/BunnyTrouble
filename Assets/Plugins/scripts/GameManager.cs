using UnityEngine;
using System.Collections;

	public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	public bool tileSelected;
	public bool plantSelected; 
	public bool paused = false;

	public GameObject tileObject;
	private BoardManager boardScript;

	//private string plantType; //Keeps track of the plant selected
	private int tileSelectedValue;//Keeps track of the value of the tile selected
	private int[] numbersSelected; //Array of numbers selected

	private int counter; //keeps track of the index of numbers selected
	private int result; //Keeps track of the result of the numbers selected

	public string vegtablePlanted;
	public bool isVegtablePlanted;

	// Keep track of how many bunnies left
	public int bunniesSaved;
	public int bunniesCrossedOver;

	public int maxBunnies = 5;
	public int bunniesInTotal = 20;

	private bool win = false;
	private bool lost = false;

	public AnimationClip bunnyTransformation;
	public NewLevel newLevel;

//	public bool notConnected;
//
//	public GameObject screenOverlay;


	private int level = 1;
	

	void Awake()
	{
		// Keeps track of the winning/lossing conditions
		bunniesSaved = 0;
		bunniesCrossedOver = 0;

		// Keeps track of when a tile/plant is selected
		tileSelected = false;
		plantSelected = false;

		// Keeps track of whether a plant has been planted and of which "type"
		vegtablePlanted = null;
		isVegtablePlanted = false;

		// Keeps track of the numbers clicked and their results
		numbersSelected = new int[] {0, 0, 0, 0};
		counter = 0;
		result = 0;

		//ensures there is only one instance of the object
		if (instance == null) {
			instance = this;
		} else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);
//		boardScript = GetComponent<BoardManager>();
//
//		InitGame();
	}


	//Getters and Setters!
	public int[] getSelectedNumbers()
	{
		return numbersSelected;
	}

	public void setSelectedNumbers(int[] array)
	{
		numbersSelected = array;
	}
	public int getCounter()
	{
		return counter;
	}

	public void setCounter(int value)
	{
		counter = value;
	}

	public void addResult(int number)
	{
		result = result + number;
	}

	public void setResult(int number)
	{
		result = 0;
	}
	
	public int getResult()
	{
		return result;
	}
	
	public void setTileSelectedValue(int value)
	{
		tileSelectedValue = value;
	}

	public int getTileSelectedValue(){
		return tileSelectedValue;
	}

	public bool correct
	{
		get{ return result == tileSelectedValue;}
	}
	

	void InitGame()
	{
		boardScript.SetupScene (level);
	}

	void Update () 
	{
		if (bunniesCrossedOver > maxBunnies) 
		{
			GameOver();
		}
		if (bunniesSaved >= bunniesInTotal - maxBunnies) //if bunniesSaves >= bunniesInTotal - maxBunnies
		{
			ResetValues();
			Invoke("ShowLevelWinScreen", bunnyTransformation.length);
		}

	}
	
	void GameOver(){
		SoundEffectsManager._instance.playGameOver ();
		ResetValues ();
		Application.LoadLevel ("gameOver");
	}

	void ShowLevelWinScreen()
	{
		SoundEffectsManager._instance.playFireWorks ();
		newLevel.ShowNewLevelScreen ();
		ResetValues ();
	}

	public void ResetValues()
	{
		bunniesCrossedOver = 0;
		bunniesSaved = 0;
		tileSelected = false;
	}

	public int Level
	{
		get{return level;}
		set{ level = value;}
	}

	public void RestartLevel()
	{
		ResetValues ();
		Application.LoadLevel (Application.loadedLevel);
	}

	public void LoadNextLevel()
	{
		win = false;
		Application.LoadLevel(Application.loadedLevel + 1);
	}

//	void HideNotConnectedScreen(){
//		screenOverlay.SetActive (false);
//		notConnected = false;
//	}
//
//	void ShowNotConnectedScreen(){
//		screenOverlay.SetActive (true);
//		notConnected = true;
//	}
	

		
	}
