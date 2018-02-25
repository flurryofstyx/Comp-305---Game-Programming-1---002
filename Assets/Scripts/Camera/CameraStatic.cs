using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStatic : MonoBehaviour
{

    public Transform playerPosition;
    public float viewSize = 5;

    // Use this for initialization
    void Start()
    {
        this.GetComponent<Camera>().orthographicSize = viewSize;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}