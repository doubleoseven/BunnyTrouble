using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour
{

	// Usued to decide which enemy prefab to instantiate
	public enum EnemyLevels
	{
		Easy,
		Medium, 
		Hard,
		Boss
	}


	public EnemyLevels enemyLevel = EnemyLevels.Easy;

	// The enemy prefabs
    public GameObject EasyEnemy;
	public GameObject MediumEnemy;
	public GameObject HardEnemy;
	public GameObject BossEnemy;

	private Dictionary<EnemyLevels, GameObject> Enemies = new Dictionary<EnemyLevels, GameObject>(4);

	public int totalEnemy = 10;
	public float timeToWaitBeforeEachWave = 5f;
	public float timeToWait = 10f;

	// Keeps track of how many enemies are in the current wave
	private int currentEnemy = 0;
	// Keeps track of how many enemies have been instiantiated from the beginning 
	private int spawnedEnemy = 0; 

	// the spawn states. 
	private bool waveSpawn = true;
	public bool spawn = false;

	//public float orignalSpawnTime = 15f;
	[Range (5, 14)]
	public float minSpawnTime = 5;
	[Range (15, 26)]
	public float maxSpawnTime = 20;

	public float spawnTimer;
	private float timeTillSpawn = 0.0f;

	// time wave controlls
	public float waveTimer = 30.0f; 
	private float timeTillWave = 0.0f;

	// Waves Controls
	public int totalWaves = 5;
	private int currentWaves = 0;

	public GameObject WaveText;

    public Transform[] spawnPoints;


    void Start ()
    {
		WaveText = GameObject.FindGameObjectWithTag ("WaveManager");
		spawnTimer = Random.Range (minSpawnTime, maxSpawnTime);
		Enemies.Add (EnemyLevels.Easy, EasyEnemy);
		Enemies.Add (EnemyLevels.Medium, MediumEnemy);
		Enemies.Add (EnemyLevels.Hard, HardEnemy);
		Enemies.Add (EnemyLevels.Boss, BossEnemy);
		//InvokeRepeating ("Spawn", orignalSpawnTime, Random.Range (minSpawnTime, maxSpawnTime));

		SetTotalBunnies ();

		Invoke ("InvokeShowWaveScreen", timeToWait);

	}
    void Spawn ()
    {
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		Instantiate (Enemies[enemyLevel], spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
		currentEnemy++;
		spawnedEnemy++;
		timeTillSpawn = 0.0f;
    }


	void Update()
	{

		if (spawn) 
		{

			if(currentWaves < totalWaves)
			{
				if(currentWaves == (totalWaves-1))
				{
					enemyLevel = EnemyLevels.Medium;
				}


				timeTillWave+= Time.deltaTime;
				if(waveSpawn)
				{
					timeTillSpawn += Time.deltaTime;
					if(timeTillSpawn >= spawnTimer)
					{
						Spawn();
					}
				}

				//The total number of enemies that need to be spawned in one wave has been reached.
				if(timeTillWave >= waveTimer)
				{
					if(spawnedEnemy % totalEnemy == 0)
					{
						waveSpawn = true;
						timeTillWave = 0.0f;
						currentWaves++;
						currentEnemy = 0;
						if(currentWaves!=totalWaves)
						{
							StartCoroutine(ShowWaveScreen());
						}
					}
				}

				if(currentEnemy >= totalEnemy)
				{
					waveSpawn = false;
				}
			} 
			else
			{
				spawn = false;
			}
		}
	}

	public void InvokeShowWaveScreen()
	{
		StartCoroutine(ShowWaveScreen());
	}

	IEnumerator ShowWaveScreen()
	{
		spawn = false;
		WaveText.BroadcastMessage ("ChangeWaveNumber", currentWaves+1);
		WaveText.BroadcastMessage ("FlyInAnimation");
		yield return new WaitForSeconds (timeToWaitBeforeEachWave);
		spawn = true;
	}

	void SetTotalBunnies()
	{
		GameManager.instance.bunniesInTotal = totalEnemy * totalWaves;
	}

	public int CurrentEnemy
	{
		get{return currentEnemy;}
		set{currentEnemy -= value;} //subtract the value from current Enemy
	}

	public void killEnemy()
	{
		CurrentEnemy = 1;
	}

}
