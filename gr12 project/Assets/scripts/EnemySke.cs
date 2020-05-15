using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySke : MonoBehaviour
{
    GameObject Player;
    int MoveSpeed = 4;
    int MaxDist = 30;
    int MinDist = 9;
    int shootDist = 10;

    public Transform target;
    public GameObject projectile;
 
    public float maximumLookDistance = 30;
    public float maximumAttackDistance = 10;
    public float minimumDistanceFromPlayer = 2;

    public float arrowSpeed=5;
 
    public float rotationDamping = 2;
 
    public double shotInterval = 0.5;
 
    private float shotTime = 0;

    public float health;

    void Start()
    {
       
    }

   
    void Update()
    {
        ChasePlayer();
        HealthCheck();
        var distance = Vector3.Distance(target.position, transform.position);

        if (distance <= maximumLookDistance)
        {
            LookAtTarget();

            //Check distance and time
            if (distance <= maximumAttackDistance && (Time.time - shotTime) > shotInterval)
            {
                Shoot();
            }
        }
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

 
    void LookAtTarget()
    {
        var dir = target.position - transform.position;
        dir.y = 0;
        var rotation = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationDamping);
    }

    void Shoot()
    {
        //Reset the time when we shoot
        shotTime = Time.time;
        GameObject Arrow = Instantiate(projectile, transform.position + (target.position - transform.position).normalized, Quaternion.LookRotation(target.position - transform.position));
        Rigidbody rb = Arrow.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * arrowSpeed;

    }
}
