using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;
    MeshRenderer rend;
    Rigidbody rigidBody;

    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        
        GetComponent<Renderer>().enabled = false;
        rigidBody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            Debug.Log("Time to drop");
            rend.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
