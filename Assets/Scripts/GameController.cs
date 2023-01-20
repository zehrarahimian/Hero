using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject GameOverPanel;
   // public GameObject PausePanel;
    
    void Start()
    {
        GameOverPanel.SetActive(false);
       // PausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game1");
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    
    public void Pause()
    {
       // PausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }
}
