using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {
    //Spawn inputs of enemies, lifes, harder_enemies
    public GameObject obstacle;
	// Use this for initialization
	void Start () {
        Instantiate(obstacle, transform.position, Quaternion.identity);
	}
	
}
