using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 15f;
    public Transform[] spawnPoints;


    void Start ()
    {
<<<<<<< HEAD
        InvokeRepeating ("Spawn", spawnTime, Random.Range (15,30));
=======
        InvokeRepeating ("Spawn", spawnTime, Random.Range(15, 30));
>>>>>>> origin/master
    }


    void Spawn ()
    {
       // if(playerHealth.currentHealth <= 0f)
       // {
         //   return;
       // }

        int spawnPointIndex = Random.Range (0, spawnPoints.Length);

        Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
