using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    //Array of spawn prefabs
    [Header("Spawn Prefabs")]
    [SerializeField] private GameObject[] obstaclePattern;
    private float timeBTWSpawn;
    [Header("Time to set Spawn")]
    [SerializeField] private float startTimeBTWSpawn;
    [SerializeField] private float decreaseTime;
    [SerializeField] private float minTime;
	
	// Update is called once per frame
	void Update () {
		if(timeBTWSpawn <= 0)
        {
            //Get random spawn prefab to instantiate into the world
            int rand = Random.Range(0, obstaclePattern.Length);
            Instantiate(obstaclePattern[rand], transform.position, Quaternion.identity);
            timeBTWSpawn = startTimeBTWSpawn;
            if(startTimeBTWSpawn > minTime)
            {
                //spawning time fastar to increase posibilites of a gameover
                startTimeBTWSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBTWSpawn -= Time.deltaTime;
        }
	}
}
