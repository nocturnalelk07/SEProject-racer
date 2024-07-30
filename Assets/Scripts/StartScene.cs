using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("Volume");
        //Debug.Log("the volume is: " + PlayerPrefs.GetFloat("Volume"));
    }
}
