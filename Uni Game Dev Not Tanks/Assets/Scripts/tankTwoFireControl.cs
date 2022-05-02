using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankTwoFireControl : MonoBehaviour
{
    //Declare Variables
    public GameObject firingMechanic;
    public Transform turretPos1;
    public Transform turretPos2;
    public Transform turretPos3;
    public Transform turretPos4;
    public Transform turretPos5;
    public Transform turretPos6;
    public Transform turretPos7;
    public Transform turretPos8;
    public Transform turretPos9;
    public Transform turretPos10;
    public Transform turretPos11;
    public Transform turretPos12;
    public bool fireAvailability = true;

    // Update is called once per frame
    void Update()
    {
        //When player presses fire button
        if (Input.GetButtonDown("FireTurret"))
        {
            //run fire script
            Fire();
            

        }
        //fire script
        void Fire()
        {
            //check where turret is pointing and shooting from that position and at that angle
            if (TurnManager.turn == true && TurnManager.missileInAir == false)
            {
                if (tankTwoController.turretPos == 1)
                {
                    GameObject si = Instantiate(firingMechanic, turretPos1);
                    si.transform.parent = null;
                }
                else if (tankTwoController.turretPos == 2)
                {
                    GameObject si = Instantiate(firingMechanic, turretPos2);
                    si.transform.parent = null;
                }
                else if (tankTwoController.turretPos == 3)
                {
                    GameObject si = Instantiate(firingMechanic, turretPos3);
                    si.transform.parent = null;
                }
                else if (tankTwoController.turretPos == 4)
                {
                    GameObject si = Instantiate(firingMechanic, turretPos4);
                    si.transform.parent = null;
                }
                else if (tankTwoController.turretPos == 5)
                {
                    GameObject si = Instantiate(firingMechanic, turretPos5);
                    si.transform.parent = null;
                }
                else if (tankTwoController.turretPos == 6)
                {
                    GameObject si = Instantiate(firingMechanic, turretPos6);
                    si.transform.parent = null;
                }
                else if (tankTwoController.turretPos == 7)
                {
                    GameObject si = Instantiate(firingMechanic, turretPos7);
                    si.transform.parent = null;
                }
                else if (tankTwoController.turretPos == 8)
                {
                    GameObject si = Instantiate(firingMechanic, turretPos8);
                    si.transform.parent = null;
                }
                else if (tankTwoController.turretPos == 9)
                {
                    GameObject si = Instantiate(firingMechanic, turretPos9);
                    si.transform.parent = null;
                }
                else if (tankTwoController.turretPos == 10)
                {
                    GameObject si = Instantiate(firingMechanic, turretPos10);
                    si.transform.parent = null;
                }
                else if (tankTwoController.turretPos == 11)
                {
                    GameObject si = Instantiate(firingMechanic, turretPos11);
                    si.transform.parent = null;
                }
                else if (tankTwoController.turretPos == 12)
                {
                    GameObject si = Instantiate(firingMechanic, turretPos12);
                    si.transform.parent = null;
                }

            }
            else
            {

                return;

            }

        }
        
    }
}
