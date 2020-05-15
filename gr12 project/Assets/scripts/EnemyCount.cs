using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCount : MonoBehaviour
{
    public int count; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemies")
        {
            count++;
        }
    }



}
