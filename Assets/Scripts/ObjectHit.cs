using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player")
        {
        GetComponent<MeshRenderer>().material.color = Color.blue; 
        }
    }

    private void OnCollisionExit(Collision other) {
        GetComponent<MeshRenderer>().material.color = Color.grey;
    }
 
}
