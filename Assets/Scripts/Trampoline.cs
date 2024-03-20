using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField]private float x;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Vector2 force = new Vector2(0, x);
            rb.AddForce( force, ForceMode2D.Impulse);
        }
    }
}
