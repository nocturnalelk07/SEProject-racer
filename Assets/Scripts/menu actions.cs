using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuActions : MonoBehaviour
{
    public int mainMenu = 0;
    public int firstScene = 1;
    public void QuitApplication()
    {
        Application.Quit();
        Debug.Log("quit game");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(firstScene);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
