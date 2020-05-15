using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    // public GameObject explosionVFX;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Attack" && other.tag != "Player" && other.tag != "Check" && other.tag != "EnemyAttack")
        {
            Destroy(gameObject);
            Debug.Log("fire die");
        }
        
     
       
        //Instantiate(explosionVFX, transform.position, transform.rotation);
    }
}
