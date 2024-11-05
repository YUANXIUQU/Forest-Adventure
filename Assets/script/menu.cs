using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject start_menu;
    public GameObject lose_info;
    public GameObject win_info;
    public GameObject dialogbox;
    public timecount timecount;
    void Start()
    {
        
        lose_info.SetActive(false);
        win_info.SetActive(false);
        Time.timeScale = 0;
    }
    public void PlayGame()
    {
        dialogbox.SetActive(true);
        timecount.GetComponent<timecount>().Startgametime();
        Time.timeScale = 1;
        start_menu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void playagain()
    {
        health_management.health = 3;
        Time.timeScale = 1;
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
  
}
