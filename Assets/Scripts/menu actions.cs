using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuActions : MonoBehaviour
{
    public int firstScene = 1;
    public void QuitApplication()
    {
        Application.Quit();
        //Debug.Log("quit game");
    }

    public void StartGame()
    {
            SceneManager.LoadScene(firstScene);
    }
}
