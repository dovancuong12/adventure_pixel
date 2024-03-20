using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Player : MonoBehaviour
{
    [SerializeField] private int HP , maxHP;

    private void Start()
    {
        maxHP= HP = 10; 
    }

    public int GetHP() => HP;
    public void SetHP(int value) => HP = value;
    
    
}
