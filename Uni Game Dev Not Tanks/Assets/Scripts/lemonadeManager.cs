using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lemonadeManager : MonoBehaviour
{
    //declare variables
    public static int health = 100;

    public Sprite lemon1;
    public Sprite lemon2;
    public Sprite lemon3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //let sprite reflect health
        if (health > 80)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = lemon1;
        }
        else if (health < 81 && health > 20)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = lemon2;
        }
        else if (health < 21 && health > 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = lemon3;
        }
        else if (health < 1)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //take damage when misile hits
        if (collision.tag == "Missile")
        {
            health = health - 10;
            TurnManager.missileLanded = true;
            Debug.Log(health);
        }

    }
}
