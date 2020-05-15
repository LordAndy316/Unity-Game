using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{

    public GameObject[] enemies;

    //Array of enemy prefabs.
    public Vector3 enposition;
  
    void Spawn()
    {
        //Instantiate a random enemy.
        int enemyIndex = Random.Range(0, enemies.Length);
        Instantiate(enemies[enemyIndex], enposition, transform.rotation);
    }

}
