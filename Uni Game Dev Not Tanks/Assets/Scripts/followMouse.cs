using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouse : MonoBehaviour
{

    void Update()
    {
        //if lemon stand follow mouse at correct ground coords
        if (defencePlacement.buttonSelector == 0)
        {

            Vector2 screenPosition = new Vector2(Input.mousePosition.x, 120);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
            transform.position = worldPosition;

        }
        // if tank trap follow mouse at correct ground coords
        if (defencePlacement.buttonSelector == 1)
        {

            Vector2 screenPosition = new Vector2(Input.mousePosition.x, 50);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
            transform.position = worldPosition;

        }
    }
}
