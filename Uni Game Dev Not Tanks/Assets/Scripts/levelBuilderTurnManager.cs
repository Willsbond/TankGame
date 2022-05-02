using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelBuilderTurnManager : MonoBehaviour
{
    //declare variables
    public static bool turn = false;

    public Sprite P1;
    public Sprite P2;

    public static int defencesPlaced = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //when first five defences have been placed its player twos turn
        if (defencesPlaced == 5)
        {

            turn = true;
 

        }
        //display turn indecator
        if (turn == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = P1;
        }
        else if (turn == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = P2;
        }


    }
}
