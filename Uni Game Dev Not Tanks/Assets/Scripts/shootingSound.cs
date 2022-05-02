using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingSound : MonoBehaviour
{

    AudioSource shoot;

    public void shootingNoise()
    {

        GetComponent<AudioSource>().Play();

    }

}
