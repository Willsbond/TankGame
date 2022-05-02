using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reloadingIndecator : MonoBehaviour
{
    //declare variables
    public Sprite waiting;
    public Sprite r2F;
    public Sprite reloading;

    // Start is called before the first frame update
    void Start()
    {
        //show initial ready to fire availability
        this.gameObject.GetComponent<SpriteRenderer>().sprite = r2F;

    }

    // Update is called once per frame
    void Update()
    {
        //when player has fired show reloading till missile lands and turn chnages
        if (TurnManager.missileInAir == true && TurnManager.missileLanded == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = reloading;
        }
        else if (TurnManager.missileInAir == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = r2F;
        }

    }
}
