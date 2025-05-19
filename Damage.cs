using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
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
        
        Destroy(gameObject);
        if(collision.gameObject.tag == "enemy")
        {
            print("shot");
            enemy enemy = collision.gameObject.GetComponent<enemy>();
            enemy.TakeDamage(2);

        }

    }
}
