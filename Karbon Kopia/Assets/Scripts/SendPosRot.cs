using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendPosRot : MonoBehaviour
{
    public float forwardBack;
    public float downUp;
    public float rotate;
    public float divider = 10.0f;
    private float minValue = 0.0f;
    private float maxValue = 1.0f;

    private void Update()
    {
        forwardBack = Mathf.Clamp((transform.position.z / divider), minValue, maxValue);
        downUp = Mathf.Clamp((transform.position.y / divider), minValue, maxValue);
        rotate = Mathf.Clamp(transform.rotation.y, minValue, maxValue);
    }

    public float ForwardBack
    {
        get
        {
            return forwardBack;
        }
        set
        {
            forwardBack = value;
        }
    }
    public float DownUp
    {
        get
        {
            return downUp;
        }
        set
        {
            downUp = value;
        }
    }
    public float Rotate
    {
        get
        {
            return rotate;
        }
        set
        {
            rotate = value;
        }
    }
}
