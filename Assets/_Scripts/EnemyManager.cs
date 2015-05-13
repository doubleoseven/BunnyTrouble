using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //public PlayerHealth playerHealth;
    public GameObject enemy;
	public GameObject enemy1;
    public float spawnTime = 15f;
    public Transform[] spawnPoints;


    void Start ()
    {
		InvokeRepeating ("Spawn", spawnTime, Random.Range (15, 26));
	}
    void Spawn ()
    {
       // if(playerHealth.currentHealth <= 0f)
       // {
         //   return;
       // }
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
