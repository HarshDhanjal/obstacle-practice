using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //these variables change the movement speed 
    [SerializeField]float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()

    {
        Debug.Log("Use WASD or Arrow Keys to play the game");
    }

    void MovePlayer()

    {
        float xValue  = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        //float yvalue = Input.GetAxis("Jump") * Time.deltaTime * moveSpeed;
        float zValue  = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }

}
