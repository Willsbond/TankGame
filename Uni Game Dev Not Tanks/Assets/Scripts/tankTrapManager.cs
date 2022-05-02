using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankTrapManager : MonoBehaviour
{
    //declare variables
    public static int health = 100;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if no health destroy object
        if (health < 1)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //when hit by missile take damage
        if (collision.tag == "Missile")
        {
            health = health - 10;
            TurnManager.missileLanded = true;
            Debug.Log(health);
        }

    }
}
