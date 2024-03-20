using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Checkpoint : MonoBehaviour
{
    public Animator animator;
    public GameObject gameobjectPlayer, spawnPlayer;
    public Player player;
    private bool checkpoint1;
    private Vector3 respawnPos;
    
    public bool GetCheckpoint1()
    {
        return checkpoint1; 
    }

    private void Update()
    {
        int HP = player.GetHP();
        if (HP <= 0 && checkpoint1)
        {
            player.SetHP(10);
            Vector3 spawnPos = new Vector3(Random.Range(8.6f , 9.2f), (float)-3.4, 0);
            spawnPlayer = Instantiate(gameobjectPlayer,spawnPos,Quaternion.identity);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            checkpoint1 = true;
            animator.Play("checkpoint");
        }
    }
}
