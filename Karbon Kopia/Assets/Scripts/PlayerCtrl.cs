using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float horizontalinput;
    public float verticalIntput;
    public float speed = 20.0f;
    public float turnSpeed = 120.0f;
    void Start()
    {
        
    }

    void Update()
    {
        //Inputs
        horizontalinput = Input.GetAxis("Horizontal");
        verticalIntput = Input.GetAxis("Vertical");
        
        //Moves forward
        transform.Translate(Vector3.forward * verticalIntput * Time.deltaTime * speed);

        //Rotates
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalinput);
    }
}
