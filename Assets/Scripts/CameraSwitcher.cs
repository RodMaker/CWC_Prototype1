using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    /* (MY VERSION)
    private bool cameraKeyInput = false;
    private bool changedCamera = false;
    public GameObject camera1;
    public GameObject camera2;*/
    public KeyCode switchCameraKey;
    public Camera camera1;
    public Camera camera2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* (MY VERSION) 
        cameraKeyInput = Input.GetButtonDown("Fire1");

        if (!cameraKeyInput)
        {
            return;
        }

        // Toogle the active camera
        if (cameraKeyInput && changedCamera == false)
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
            changedCamera = true;
            return;
        } 
        else if (cameraKeyInput && changedCamera == true)
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
            changedCamera = false;
            return;
        }*/

        if (Input.GetKeyDown(switchCameraKey))
        {
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
        }
    }
}
