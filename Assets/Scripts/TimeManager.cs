using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text timeText;
    public float countDownStartValue = 80;
    public bool TimerOn = false;
    public GameObject GameOverPanel;

    void Start()
    {
        TimerOn = true;
    }


    void Update()
    {
        if(TimerOn)
        {
            if(countDownStartValue >0)
            {
                countDownStartValue -= Time.deltaTime;
                updateTimer(countDownStartValue);
                //timeText.text = ("Time: " + countDownStartValue.ToString());
            }
            else
            {
                countDownStartValue = 0;
                TimerOn = false;
                GameOverPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timeText.text = string.Format("Time: " + "{0:00} : {1:00}", minutes, seconds);
    }
    

}
