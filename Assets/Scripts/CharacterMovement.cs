using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour, IPooledObject
{
    Vector3 direction = Vector3.forward;
    float speed = 5f; 

    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 movement = direction.normalized * speed * Time.deltaTime;

        rb.MovePosition(rb.position + movement);
    }

    public void OnObjectSpawn()
    {
        speed = UIAssets.Instance.GetSpeedSlider();
    }
}
