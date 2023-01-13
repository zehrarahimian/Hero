using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score =0;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    IEnumerator score(){
        yield return new WaitForSeconds(2);
        score = score + 1;
        Debug.Log("Score: " + score);
    }
}
