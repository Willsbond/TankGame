using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnToMenu : MonoBehaviour
{
    void Update()
    {
        //when player presses escape go to menu scene
        if (Input.GetButtonDown("Cancel"))
        {

            SceneManager.LoadScene("Menu");

        }

        

    }
}
