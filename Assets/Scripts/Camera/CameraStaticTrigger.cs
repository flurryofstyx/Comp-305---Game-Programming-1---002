using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStaticTrigger : MonoBehaviour {

    public Camera mainCamera;
    public Camera staticCamera;

    // Defined by unity
    void OnTriggerEnter2D(Collider2D other)
    {
        // If the other object is a player, then do something
        if (other.gameObject.tag == "Player")
        {
            mainCamera.enabled = false;
            staticCamera.enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            staticCamera.enabled = false;
            mainCamera.enabled = true;
        }
    }
}
