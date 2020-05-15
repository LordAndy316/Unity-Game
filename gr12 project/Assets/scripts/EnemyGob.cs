using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGob : MonoBehaviour
{
    GameObject Player;
    int MoveSpeed = 6;
    int MaxDist = 30;
    int MinDist = 5;

    public float health;

    void Start()
    {
       
    }

   
    void Update()
    {
        ChasePlayer();
        HealthCheck();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.isTrigger)
        {
            health--;
        }
    }
    void ChasePlayer()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        transform.LookAt(Player.transform);

        if (Vector3.Distance(transform.position, Player.transform.position) <= MaxDist)
        {
            if (Vector3.Distance(transform.position, Player.transform.position) >= MinDist)
            {

                transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            }

        }
    }
    void HealthCheck()
    {
        if (health <= 0)
        {
            Destroy(gameObject);

        }
    }

}
