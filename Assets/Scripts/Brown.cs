using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Brown : MonoBehaviour
{
    public MovementPlayer Movement;
    [SerializeField] private float speed, min, max, x ;
    private bool cham;

    private void Start()
    {
        x = 1;
    }

    private void Update()
    {
        transform.position += Vector3.up * speed * x * Time.deltaTime;
        if (transform.position.y <= min) x = 1;
        if (transform.position.y >= max) x = -1;
        
    }

}
