using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   // public ScoreManager ScoreValue;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Enemy"){
           // ScoreValue.score +=10;
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
