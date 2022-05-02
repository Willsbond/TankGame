using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1HealthBarManager : MonoBehaviour
{
    //declare variables
    public Sprite hb1;
    public Sprite hb2;
    public Sprite hb3;
    public Sprite hb4;
    public Sprite hb5;
    public Sprite hb6;
    public Sprite hb7;
    public Sprite hb8;
    public Sprite hb9;
    public Sprite hb10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // let healthbar reflect current health
    void Update()
    {
        if (tankOneController.health > 90)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb10;
        }
        else if (tankOneController.health < 91 && tankOneController.health > 80)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb9;
        }
        else if (tankOneController.health < 81 && tankOneController.health > 70)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb8;
        }
        else if (tankOneController.health < 71 && tankOneController.health > 60)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb7;
        }
        else if (tankOneController.health < 61 && tankOneController.health > 50)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb6;
        }
        else if (tankOneController.health < 51 && tankOneController.health > 40)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb5;
        }
        else if (tankOneController.health < 41 && tankOneController.health > 30)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb4;
        }
        else if (tankOneController.health < 31 && tankOneController.health > 20)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb3;
        }
        else if (tankOneController.health < 21 && tankOneController.health > 10)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb2;
        }
        else if (tankOneController.health < 11 && tankOneController.health > 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb1;
        }
        else if (tankOneController.health < 1)
        {
            Destroy(gameObject);
        }

    }
}
