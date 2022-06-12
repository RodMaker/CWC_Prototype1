using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    //private Vector3 offset = new Vector3(0,5,-7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // OLD CODE
    /*void Update()
    {
        // Offset the camera
        // (old code) transform.position = player.transform.position;
        // (old code) transform.position = player.transform.position + new Vector3(0,5,-7);
        transform.position = player.transform.position + offset;
    }*/

    void LateUpdate()
    {
        // Offset the camera
        transform.position = player.transform.position + offset;
    }
}
