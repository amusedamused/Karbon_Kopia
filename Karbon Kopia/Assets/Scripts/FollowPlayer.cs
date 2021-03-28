using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 0, 0);
    private Vector3 newPosition;
    private Quaternion newRotation;
    public float speed;
    void Awake()
    {
        
    }

    void Update()
    {
        newPosition = transform.position;
        newRotation = transform.rotation;
        PositionChanging();
    }

    void PositionChanging()
    {
        transform.position = Vector3.Lerp(newPosition, player.transform.position,  Time.deltaTime * speed);
        transform.rotation = Quaternion.Lerp(newRotation, player.transform.rotation, Time.deltaTime * speed);
    }
}
