using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public void PlayMike()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlaySull()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void PlayAgain() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
    }


    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();     
    }
}
