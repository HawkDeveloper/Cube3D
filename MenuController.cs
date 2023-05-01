using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{
    public bool PauseGame;
    public GameObject mainMenu;
    public GameObject userControllers;
    public GameObject settings;


    public void ResetButtonDown()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );
        Play(); 
    }

    public void Play()
    {
        mainMenu.SetActive(false);
        userControllers.SetActive(true);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    public void Pause()
    {
        mainMenu.SetActive(true);
        userControllers.SetActive(false);
        Time.timeScale = 0;
        PauseGame = true;
    }

    void Start()
    {
        if( PauseGame == true)
             Time.timeScale = 0;
        else
        {
             Time.timeScale = 1f;
        }
    }
}
