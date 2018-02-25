using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCloseUpTrigger : MonoBehaviour {

    public Camera mainCamera;
    public Camera closeUpCamera;
    public Camera zoomOutCamera;
  

    // Defined by unity
    void OnTriggerEnter2D(Collider2D other)
    {
        float moveHoriz = Input.GetAxis("Horizontal");
        // If the other object is a player, then do something
        if (other.gameObject.tag == "Player" && moveHoriz > 0)
        {
            mainCamera.enabled = false;
            closeUpCamera.enabled = true;
        }
        else if (other.gameObject.tag == "Player" && moveHoriz < 0)
        {
            mainCamera.enabled = false;
            zoomOutCamera.enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            closeUpCamera.enabled = false;
            zoomOutCamera.enabled = false;
            mainCamera.enabled = true;
        }

    }
}
