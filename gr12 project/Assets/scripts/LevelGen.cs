using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    public GameObject[] rooms;
    int rand;
   

    private void Start()
    {
        int rand = Random.Range(0, rooms.Length+1);
        gen();
    }
    public void gen()
    {
        Instantiate(rooms[rand],transform.position,Quaternion.identity);
        Instantiate(rooms[rand], transform.position + Vector3.back*107, Quaternion.identity);
        Instantiate(rooms[rand], transform.position + Vector3.forward, Quaternion.identity);
        Instantiate(rooms[rand], transform.position + Vector3.forward*150, Quaternion.identity);
    }

}