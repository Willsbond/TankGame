using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class onFiringAction : MonoBehaviour
{
    //script became fairly redundent in terms of code but good for identifying objects with it attached
    public UnityEvent action;

    public void Action()
    {

        action?.Invoke();

      //  Debug.Log("Hit");

    }

    public void Action2Test()
    {

        Debug.Log("Hat");

    }

    public void Action1Test()
    {

        Debug.Log("Love");

    }



}
