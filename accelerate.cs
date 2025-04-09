using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerate : MonoBehaviour
{
    FirstPersonMovement speedchange;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "First Person Controller")
        {
            player = collision.gameObject;
            speedchange = player.GetComponent<FirstPersonMovement>();

            speedchange.speed = 15;
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        speedchange.speed = 5;
    }
}