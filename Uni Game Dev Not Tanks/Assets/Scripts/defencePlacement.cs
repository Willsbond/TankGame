using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defencePlacement : MonoBehaviour
{
    //varable decleration
    public static int buttonSelector;
    public int remaining = 10;
    public bool selected = false;
    private mdefencePlacementManager manager;

    void Start()
    {
        //look for script
        manager = GameObject.FindGameObjectWithTag("defencePlacementManager").GetComponent<mdefencePlacementManager>();

    }
    //when player selects lemon button
    public void ButtonClicked()
    {
        buttonSelector = 0;
        //assuming defences remain
        if (remaining > 0)
        {
            //place at position
            Vector2 screenPosition = new Vector2(Input.mousePosition.x, 120);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

            selected = true;

            Instantiate(manager.ItemImage[buttonSelector], new Vector3(worldPosition.x, worldPosition.y, 0), Quaternion.identity);

            remaining = remaining - 1;
            levelBuilderTurnManager.defencesPlaced = levelBuilderTurnManager.defencesPlaced + 1;
            manager.CurrentButtonPressed = buttonSelector;

        }

    }
    //player clicks trap button
    public void ButtonClicked2()
    {
        buttonSelector = 1;
        //assuming defences left
        if (remaining > 0)
        {
            //place at position
            Vector2 screenPosition = new Vector2(Input.mousePosition.x, 50);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

            selected = true;

            Instantiate(manager.ItemImage[buttonSelector], new Vector3(worldPosition.x, worldPosition.y, 0), Quaternion.identity);

            remaining = remaining - 1;
            levelBuilderTurnManager.defencesPlaced = levelBuilderTurnManager.defencesPlaced + 1;
            manager.CurrentButtonPressed = buttonSelector;

        }

    }

}
