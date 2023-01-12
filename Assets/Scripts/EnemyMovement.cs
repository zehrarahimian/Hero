using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform transform;
    public float speed = 0.5f;

    void Start()
    {
        transform = GetComponent<Transform>();
    }

    void Update()
    {
        transform.position -= new Vector3(0 , speed * Time.deltaTime , 0);
    }
}
