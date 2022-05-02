using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2HealthBarManager : MonoBehaviour
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
        //set full healthbar to show
        this.gameObject.GetComponent<SpriteRenderer>().sprite = hb5;
    }

    // let healthbar reflect current health
    void Update()
    {
        if (tankTwoController.health > 90)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb10;
        }
        else if (tankTwoController.health < 91 && tankTwoController.health > 80)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb9;
        }
        else if (tankTwoController.health < 81 && tankTwoController.health > 70)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb8;
        }
        else if (tankTwoController.health < 71 && tankTwoController.health > 60)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb7;
        }
        else if (tankTwoController.health < 61 && tankTwoController.health > 50)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb6;
        }
        else if (tankTwoController.health < 51 && tankTwoController.health > 40)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb5;
        }
        else if (tankTwoController.health < 41 && tankTwoController.health > 30)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb4;
        }
        else if (tankTwoController.health < 31 && tankTwoController.health > 20)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb3;
        }
        else if (tankTwoController.health < 21 && tankTwoController.health > 10)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb2;
        }
        else if (tankTwoController.health < 11 && tankTwoController.health > 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hb1;
        }
        else if (tankTwoController.health < 1)
        {
            Destroy(gameObject);
        }

    }
}
