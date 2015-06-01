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
<<<<<<< HEAD:Assets/_Scripts/EnemyManager.cs
		InvokeRepeating ("Spawn", spawnTime, Random.Range (15, 26));
=======
			InvokeRepeating ("Spawn", spawnTime, Random.Range (15, 20));
>>>>>>> neurofeedback2:Assets/Plugins/scripts/EnemyManager.cs
	}
    void Spawn ()
    {
       // if(playerHealth.currentHealth <= 0f)
       // {
         //   return;
       // }
<<<<<<< HEAD:Assets/_Scripts/EnemyManager.cs
		if (GameManager.instance.bunniesSaved >= 0 && GameManager.instance.bunniesSaved<5) {
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);
			Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
		} else if (GameManager.instance.bunniesSaved >= 5) 
		{
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);
			Instantiate (enemy1, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
=======
		if (GameManager.instance.notConnected == false) {
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);

			Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
>>>>>>> neurofeedback2:Assets/Plugins/scripts/EnemyManager.cs
		}
    }

}
