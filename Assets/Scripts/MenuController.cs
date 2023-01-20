using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject DescriptionPanel;
    
    void Start()
    {
        DescriptionPanel.SetActive(false);
    }

    
    void Update()
    {
        
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GoDescriptionPanel()
    {
        DescriptionPanel.SetActive(true);
    }

    public void GoLevelOne()
    {
        SceneManager.LoadScene("Game0");
    }

    public void GoLevelTwo()
    {
        SceneManager.LoadScene("Game1");
    }

    public void GoLevelThree()
    {
        SceneManager.LoadScene("Game2");
    }
}
