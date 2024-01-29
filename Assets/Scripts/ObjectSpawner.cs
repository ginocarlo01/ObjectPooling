using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    
    [SerializeField]
    string[] objectsTags;

    ObjectPooler objectPooler;
    UIAssets uiAssets;

    private float timer;
    private float timeToSpawn;

    void Start()
    {
        objectPooler = ObjectPooler.instance;
        uiAssets = UIAssets.Instance;
    }

    private void FixedUpdate()
    {

        timer += Time.deltaTime;

        timeToSpawn = uiAssets.GetTimeToSpawn();

        if(timer > timeToSpawn )
        {
            timer = 0;
            objectPooler.SpawnFromPool(objectsTags[Random.Range(0, objectsTags.Length)], transform.position, Quaternion.identity );
        }
    }
}
