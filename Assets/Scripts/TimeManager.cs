using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text timeText;
    int countDownStartValue = 5;

    void Start()
    {
         StartCoroutine(Time()); 
    }


    void Update()
    {
        timeText.text = ("Time: " + countDownStartValue.ToString());
    }

    IEnumerator Time(){
        while (countDownStartValue > 0)
        {
          yield return new WaitForSeconds(1);
          countDownStartValue --;  
        }
    }

}
