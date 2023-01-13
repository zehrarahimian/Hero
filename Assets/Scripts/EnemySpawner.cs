using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemy;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }


    void Update()
    {
        
    }

    void Enemies()
    {
        int rand = Random.Range(0, enemy.Length);
        float randXPos = Random.Range(-2.85f, 2.85f);
        Instantiate(enemy[rand], new Vector3(randXPos, transform.position.y, transform.position.z), Quaternion.identity);
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
          yield return new WaitForSeconds(3);
          Enemies();  
        }
    }
}
