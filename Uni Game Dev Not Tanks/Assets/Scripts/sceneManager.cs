using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public void loadLevel()
    {
        //load level builder
        SceneManager.LoadScene("LevelBuilder");

    }

    public void exitGame()
    {
        //quit game
        Application.Quit();
        Debug.Log("Quit Game");

    }

    public void tutorialMode()
    {
        //load tutorial
        SceneManager.LoadScene("tutorialScene");

    }


}
