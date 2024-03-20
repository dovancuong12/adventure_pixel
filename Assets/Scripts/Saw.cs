using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    [SerializeField] private float speed, min, max, x ;

    void Start()
    {
        x = 1;
    }

    void Update()
    {
        transform.position += Vector3.right * speed * x * Time.deltaTime;

        if (transform.position.x >= max)
        {
            x = -1;
        }
        else if (transform.position.x <= min)
        {
            x = 1;
        }
    }
}