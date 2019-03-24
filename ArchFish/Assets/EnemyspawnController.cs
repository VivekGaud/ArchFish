using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyspawnController : MonoBehaviour {

    public float EnemySpawnRate;
    public Transform[] spawnPoints;
    public GameObject[] enemy;
    int randomSpawnPoint, randomMonster;
    public static bool spawnAllowed;
 

	void Start () {

        InvokeRepeating("SpawnAMonster",0f,EnemySpawnRate );
		
	}
	
	
	void SpawnAMonster() {
        
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomMonster = Random.Range(0, enemy.Length);
            Instantiate(enemy[randomMonster], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
            
      

	}
}
