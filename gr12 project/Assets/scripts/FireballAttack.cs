using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAttack : MonoBehaviour
{
    public GameObject projectile;
    public Transform shooter;
    public float fireballSpeed;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Fireball = Instantiate(projectile);
            Fireball.transform.Translate(shooter.position + shooter.transform.forward);
            Rigidbody rb = Fireball.GetComponent<Rigidbody>();
            rb.velocity = shooter.transform.forward * fireballSpeed;
        }
    }
}
