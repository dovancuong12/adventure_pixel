using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Begin : MonoBehaviour
{
    public Animator animator;
    private float count, t =1f;
    private bool start = false;

    private void Update()
    {
        if(start) count += t * Time.deltaTime;
        if (count >= 5)
        {
            animator.SetBool("start", false);
            count = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            start = true;
            animator.SetBool("start", true);
        }
    }
}
