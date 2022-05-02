using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour  
{
    //declare variables
    public static bool turn = false;

    public Sprite P1;
    public Sprite P2;

    public static bool missileInAir = false;
    public static bool missileLanded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //False = Player ones turn // True = Player twos turn
        
        //when missile lands change turns
        if (missileLanded == true)
        {
            if (turn == false)
            {
                turn = true;
                missileLanded = false;
            }
            else
            {
                turn = false;
                missileLanded = false;
            }
        }

        //check whos turn it is and change display
        if (turn == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = P1;
        }
        else if (turn == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = P2;
        }

    }

   public static bool turntest()
    {

        return true;

    }


}
