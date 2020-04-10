using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform player1;
    public Vector3 offset;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = player1.position + offset;
    }
}
