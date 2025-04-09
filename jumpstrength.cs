using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpstrength : MonoBehaviour
{
    Jump jumpstrengths;
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
            jumpstrengths = player.GetComponent<Jump>();

            jumpstrengths.jumpStrength = 7;
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        jumpstrengths.jumpStrength = 2;
    }
}