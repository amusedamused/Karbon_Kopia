using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendTransform : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }
    public float HorizontalInput
    {
        get
        {
            return horizontalInput;
        }
        set
        {
            horizontalInput = value;
        }
    }
    public float VerticalInput
    {
        get
        {
            return verticalInput;
        }
        set
        {
            verticalInput = value;
        }
    }
}
