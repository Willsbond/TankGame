using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class defencePlacer : MonoBehaviour
{
    //declare variables
    public static string[] lemonLocations;
    public static string[] trapLocations;

    public GameObject lemonPrefab;
    public GameObject trapPrefab;

   //run code on game launch
    void Start()
    {

        placeLemons();
        placeTraps();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //place lemonade stands
    void placeLemons()
    {
        //read locations from file
        string path = Application.dataPath + "/lemonlocations.txt";

        lemonLocations = File.ReadAllLines(path);

        Debug.Log(lemonLocations.Length);
        //loop for number of defences
        for (int i = 0; i < lemonLocations.Length; i++)
        {

            Debug.Log("CheckA");

            Debug.Log(Convert.ToSingle(lemonLocations[i]));

            Vector2 screenPosition = new Vector2(Convert.ToSingle(lemonLocations[i]), 120);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

            Instantiate(lemonPrefab, new Vector3(Convert.ToSingle(lemonLocations[i]), worldPosition.y, 0), Quaternion.identity);

        }

    }
    // place tank traps
    void placeTraps()
    {
        //read from file
        string path2 = Application.dataPath + "/traplocations.txt";

        trapLocations = File.ReadAllLines(path2);

        Debug.Log(trapLocations.Length);
        //loop for number of defences
        for (int i = 0; i < trapLocations.Length; i++)
        {

            Debug.Log("CheckB");

            Debug.Log(Convert.ToSingle(trapLocations[i]));

            Vector2 screenPosition = new Vector2(Convert.ToSingle(trapLocations[i]), 50);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

            Instantiate(trapPrefab, new Vector3(Convert.ToSingle(trapLocations[i]), worldPosition.y, 0), Quaternion.identity);

        }

    }
}
