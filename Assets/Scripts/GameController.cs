using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject GameOverPanel;
    
    void Start()
    {
        GameOverPanel.SetActive(false);
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
}
