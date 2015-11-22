using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //public PlayerHealth playerHealth;
    public GameObject enemy;
	public GameObject enemy1;
    public float orignalSpawnTime = 15f;
	[Range (5, 14)]
	public float minSpawnTime = 5;
	[Range (15, 26)]
	public float maxSpawnTime = 20;
    public Transform[] spawnPoints;


    void Start ()
    {

		InvokeRepeating ("Spawn", orignalSpawnTime, Random.Range (minSpawnTime, maxSpawnTime));

	}
    void Spawn ()
    {
        if(GameManager.instance.paused)
        {
            return;
        }

		if (GameManager.instance.notConnected == false)
			{
			if (GameManager.instance.bunniesSaved >= 0 && GameManager.instance.bunniesSaved<5) {
				int spawnPointIndex = Random.Range (0, spawnPoints.Length);
				Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
			} else if (GameManager.instance.bunniesSaved >= 5) 
			{
				int spawnPointIndex = Random.Range (0, spawnPoints.Length);
				Instantiate (enemy1, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
				}
		}
    }

}
