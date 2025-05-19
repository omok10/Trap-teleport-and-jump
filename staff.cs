using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staff : MonoBehaviour

{
    public Transform staffdirection;


    void Start()
    {

    }

    void Update()
    {
        Vector3 cameraEuler = staffdirection.rotation.eulerAngles;

        // Apply the camera's rotation, but add 90 degrees to the X axis
        transform.rotation = Quaternion.Euler(
            cameraEuler.x + 90f,
            cameraEuler.y,
            cameraEuler.z
        );
    }
}

        
    


