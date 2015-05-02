using UnityEngine;
using System.Collections;

public class EnemySpawnController : MonoBehaviour {
	
	
	
	public static EnemySpawnController Instance;
	
	
	
	public GameObject Enemy;
	
	public GameObject EnemyTwo;
	
	
	
	public float spawnArea = 1.5f;
	
	
	
	void Awake() {
		
		Instance = this;
		
	}
	
	
	
	
	
	public void SpawnEnemies() {
		
		//Array
		
		GameObject[] enemySpawnSystem = GameObject.FindGameObjectsWithTag("EnemySpawnPoint");
		
		//loop to create enemies
		
		int i = 0;
		
		
		
		foreach(GameObject spawnPoint in enemySpawnSystem)
			
		{
			
			int noEnemies = Random.Range(1,4);
			
			for (int j= 0; j < noEnemies; j++)
				
			{
				
				i++;
				
				GameObject enemy;
				
				enemy = Instantiate(Enemy, new Vector3(spawnPoint.transform.position.x + Random.Range(-spawnArea, spawnArea), 
				                                       
				                                       spawnPoint.transform.position.y + Random.Range(-spawnArea, spawnArea),
				                                       
				                                       spawnPoint.transform.position.z + Random.Range(-spawnArea, spawnArea)),
				                    
				                    spawnPoint.transform.rotation) as GameObject;
				
				enemy.name = "Enemy"+i;
				
				
				
			}
			
		}
		
	}   
	
}