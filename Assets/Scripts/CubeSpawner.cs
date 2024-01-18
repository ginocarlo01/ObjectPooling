using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    ObjectPooler objectPooler;
   
    void Start()
    {
        objectPooler = ObjectPooler.instance;
    }

    private void FixedUpdate()
    {
        objectPooler.SpawnFromPool("Cube", transform.position, Quaternion.identity);
    }
}
