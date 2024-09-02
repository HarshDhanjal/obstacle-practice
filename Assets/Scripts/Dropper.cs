using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]float DropTime = 0f;
    MeshRenderer renderer;
    Rigidbody rigidBody;

    void Start ()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
  {
        Debug.Log("Time elapsed :" + Time.time);   

            if (Time.time > DropTime) 
    {
        renderer.enabled = true;
        rigidBody.useGravity = true;
    }
   }
}
    

