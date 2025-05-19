using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    private int health = 10;
    public void TakeDamage(int Damage)
    {
        health = health - Damage;
        if (health <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
        print(health);

    }

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
