using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    int doorHeight = 15;
   
  
    void OnTriggerEnter(Collider collider)
    {
        
        if (collider.tag == "Player")
        {
            Debug.Log("door opened");
            transform.Translate(Vector3.up * doorHeight);
           
        }
    }
}
