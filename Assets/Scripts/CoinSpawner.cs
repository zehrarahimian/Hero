using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefabs;

    void Start()
    {
        StartCoroutine(coinSpawner());
    }


    void Update()
    {
        
    }

    void CoinSpawn()
    {
        float rand = Random.Range(-2.85f, 2.85f);
        Instantiate(coinPrefabs, new Vector3(rand, transform.position.y, transform.position.z), Quaternion.identity);
    }

    IEnumerator coinSpawner(){
        while (true)
        {
            int time = Random.Range(5,20);
            yield return new WaitForSeconds(time);
            CoinSpawn();
        }
    }
}
