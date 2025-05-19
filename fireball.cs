using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    public GameObject fire;
    public Transform cameraTrans;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        Vector3 cameraEuler = cameraTrans.rotation.eulerAngles;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(fire, transform.position, Quaternion.Euler(
            cameraEuler.x,
            cameraEuler.y,
            cameraEuler.z));

        }
    }
}
