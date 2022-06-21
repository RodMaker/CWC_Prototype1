using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    // Locomotion
    private float speed = 20f; //(old code)
    private float horsePower = 20f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;

    // Public Variables
    // Camera Switch
    //public KeyCode switchCameraKey; (old code)
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;

    // Local Multiplayer
    public string inputID;

    // Wheels
    private float rotationSpeed = 1000.0f;
    private float rotationSpeed2 = 10.0f;
    public GameObject wheelsFL;
    public GameObject wheelsFR;
    public GameObject wheelsRL;
    public GameObject wheelsRR;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); // dar o check
    }

    // Changed from normal Update to FixedUpdate
    void FixedUpdate()
    {
        // OLD CODE
        //transform.Translate(0,0,1);
        //transform.Translate(Vector3.forward);
        //transform.Translate(Vector3.forward * Time.deltaTime * 20);
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        // Check for input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        verticalInput = Input.GetAxis("Vertical" + inputID);

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput); //(old code)
        //playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower);
        
        // Rotate the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        // Switch the camera
        if (Input.GetButtonDown("SwitchCamera" + inputID))
        {
            if (camera1.enabled)
            {
                camera1.enabled = !camera1.enabled;
                camera2.enabled = !camera2.enabled;
            }
            else if (camera2.enabled)
            {
                camera2.enabled = !camera2.enabled;
                camera3.enabled = !camera3.enabled;
            }
            else if (camera3.enabled)
            {
                camera3.enabled = !camera3.enabled;
                camera1.enabled = !camera1.enabled;
            }
        }

        // Rotate the wheels
        if (verticalInput > 0)
        {
            wheelsFL.transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
            wheelsFR.transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
            wheelsRL.transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
            wheelsRR.transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
        }
        else if (verticalInput < 0)
        {
            wheelsFL.transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
            wheelsFR.transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
            wheelsRL.transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
            wheelsRR.transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
        }

        if (horizontalInput > 0)
        {
            wheelsFL.transform.localRotation = Quaternion.AngleAxis(30, wheelsFL.transform.up);
            wheelsFR.transform.localRotation = Quaternion.AngleAxis(30, wheelsFL.transform.up);
        }
        else if (horizontalInput < 0)
        {
            wheelsFL.transform.localRotation = Quaternion.AngleAxis(-30, wheelsFL.transform.up);
            wheelsFR.transform.localRotation = Quaternion.AngleAxis(-30, wheelsFL.transform.up);
        }

        /*
        Tentativa

        if (horizontalInput > 0)
        {
            wheelsFL.transform.Rotate(Vector3.up * rotationSpeed2 * Time.deltaTime);
            wheelsFR.transform.Rotate(Vector3.up * rotationSpeed2 * Time.deltaTime);
        }
        else if (horizontalInput < 0)
        {
            wheelsFL.transform.Rotate(Vector3.down * rotationSpeed2 * Time.deltaTime);
            wheelsFR.transform.Rotate(Vector3.down * rotationSpeed2 * Time.deltaTime);
        }
        
        if (wheelsFL.transform.rotation.y < 30 && wheelsFL.transform.rotation.y > 30)

        if (horizontalInput > 0)
        {
            wheelsFL.transform.Rotate(0,45,0 * Time.deltaTime);
            wheelsFR.transform.Rotate(0,45,0 * Time.deltaTime);
        }
        else if (horizontalInput < 0)
        {
            wheelsFL.transform.Rotate(0,-45,0 * Time.deltaTime);
            wheelsFR.transform.Rotate(0,-45,0 * Time.deltaTime);
        }

        // vantreeseba input
        if(horizInput > 0) 
        {
            wheelsFL.transform.localRotation = Quaternion(angle, wheelsFL.transform.up);
        }
        */
    }
}
