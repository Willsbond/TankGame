using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class mdefencePlacementManager : MonoBehaviour
{
    //decalre variables
    public defencePlacement[] ItemButtons;
    public GameObject[] ItemPrefabs;
    public GameObject[] ItemImage;
    public int CurrentButtonPressed;

    public static double[] defenceLocations;
    public static int defencesPlaced = 0;

    public static bool firstLemon = true;
    public static bool firstTrap = true;

    public static int writtenToFile = 0;

    //write locations to files
    void CreateText(double location) 
    {

        string path = Application.dataPath + "/lemonlocations.txt";

        if (!File.Exists(path))
        {

            File.WriteAllText(path, location.ToString() + "\n");

        }

        if (firstLemon == true)
        {

            firstLemon = false;
            File.WriteAllText(path, location.ToString() + "\n");
            writtenToFile = writtenToFile + 1;


        }
        else if (firstLemon == false)
        {

            File.AppendAllText(path, location.ToString() + "\n");
            writtenToFile = writtenToFile + 1;


        }

    }
    //write locations of traps to file
    void CreateText2(double location)
    {

        string path = Application.dataPath + "/traplocations.txt";

        if (!File.Exists(path))
        {

            File.WriteAllText(path, location.ToString() + "\n");


        }

        if (firstTrap == true)
        {

            firstTrap = false;
            File.WriteAllText(path, location.ToString() + "\n");
            writtenToFile = writtenToFile + 1;


        }
        else if (firstTrap == false)
        {

            File.AppendAllText(path, location.ToString() + "\n");
            writtenToFile = writtenToFile + 1;


        }

    }

    private void Update()
    {
        //once all locations have been written to file start main game
        if (writtenToFile == 10)
        {

            SceneManager.LoadScene("SampleScene");

        }
        //place selected defence in world from button selected
        if (defencePlacement.buttonSelector == 0)
        {
            Vector2 screenPosition = new Vector2(Input.mousePosition.x, 120);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

            if (Input.GetMouseButtonDown(0) && ItemButtons[CurrentButtonPressed].selected)
            {

                ItemButtons[CurrentButtonPressed].selected = false;
                Instantiate(ItemPrefabs[CurrentButtonPressed], new Vector3(worldPosition.x, worldPosition.y, 0), Quaternion.identity);

                defencesPlaced = defencesPlaced + 1;
                Debug.Log(defencesPlaced);

                Debug.Log(worldPosition.x);
                CreateText(worldPosition.x);

                Destroy(GameObject.FindGameObjectWithTag("ItemPlaceholder"));
            }
        }
        //see above
        if (defencePlacement.buttonSelector == 1)
        {
            Vector2 screenPosition = new Vector2(Input.mousePosition.x, 50);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

            if (Input.GetMouseButtonDown(0) && ItemButtons[CurrentButtonPressed].selected)
            {

                ItemButtons[CurrentButtonPressed].selected = false;
                Instantiate(ItemPrefabs[CurrentButtonPressed], new Vector3(worldPosition.x, worldPosition.y, 0), Quaternion.identity);

                defencesPlaced = defencesPlaced + 1;
                Debug.Log(defencesPlaced);

                Debug.Log(worldPosition.x);
                CreateText2(worldPosition.x);

                Destroy(GameObject.FindGameObjectWithTag("ItemPlaceholder"));
            }
        }

    }

}
