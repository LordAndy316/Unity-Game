using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public bool godMode = false;
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="EnemyAttack" && godMode==false)
        {
            health--;

        }

    }
}
