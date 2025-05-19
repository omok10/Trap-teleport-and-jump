using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;


    public int health = 10;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =
        Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        transform.LookAt(target.position);
    }
    private void OnCollisionEnter(Collision other)
   
    {
        
        if (other.gameObject.name== "First Person Controller") 
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
            print("was triggered");
            player player = other.gameObject.GetComponent<player>();

            player.TakeDamage(playerDamage);

        }
       
    }
    public void TakeDamage(int damage)
    {
        health = health - damage;
        if(health <=0)
        {
            Destroy(gameObject);
        }
    }
   
}
