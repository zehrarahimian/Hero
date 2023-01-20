using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score =0;
    public Text scoreText;
    public GameObject WinPanel;

    void Start()
    {
        StartCoroutine(Score());
        WinPanel.SetActive(false); 
    }


    void Update()
    {
        scoreText.text = ("Score: " + score.ToString());
        if(score == 200)
        {
            Time.timeScale = 0;
            WinPanel.SetActive(true);
        }
    }

    IEnumerator Score(){
        while (true)
        {
          yield return new WaitForSeconds(2);
          score = score + 1;  
        }
    }
}
