using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firingMechanic : MonoBehaviour
{
    //declare variables
    public float speed;

    void Start()
    {
        //when prefab spawns play explosion sound as cannon fire
        TurnManager.missileInAir = true;
        GetComponent<AudioSource>().Play();
    }

    void Update()
    {
        //missile movement
        transform.Translate(transform.right * transform.localScale.x * speed * Time.deltaTime);

    }
    //when missile hits something
    void OnTriggerEnter2D(Collider2D collision)
    {
        //if players turn
        if (TurnManager.turn == false)
        {
            if (collision.tag == "P1")
            {
                return;
            }

            if (collision.tag == "Ground")
            {
                GetComponent<AudioSource>().Play();
                Destroy(gameObject);
                TurnManager.missileInAir = false;
                TurnManager.missileLanded = true;
                

            }

     //check if object hit has script for destoryable object
            if (collision.GetComponent<onFiringAction>())
            {

                onFiringAction temp = FindObjectOfType<onFiringAction>();
                temp.Action();

                GetComponent<AudioSource>().Play();
                Destroy(gameObject);
                TurnManager.missileInAir = false;
                TurnManager.missileLanded = true;
                


            }
        }
        // if player 2 turn
        if (TurnManager.turn == true)
        {
            if (collision.tag == "P2")
            {
                return;
            }

            if (collision.tag == "Ground")
            {
                GetComponent<AudioSource>().Play();
                Destroy(gameObject);
                TurnManager.missileInAir = false;
                TurnManager.missileLanded = true;
                

            }

       //check if object has script to indicate destoryable
            if (collision.GetComponent<onFiringAction>())
            {

                onFiringAction temp = FindObjectOfType<onFiringAction>();
                temp.Action();

                GetComponent<AudioSource>().Play();
                Destroy(gameObject);
                TurnManager.missileInAir = false;
                TurnManager.missileLanded = true;
                

            }
        }


    }

}
