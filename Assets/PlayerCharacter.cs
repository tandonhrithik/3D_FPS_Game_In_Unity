using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Hurt(int Damage)
    {
        health -= Damage;
        Debug.Log($"Health: {health}");
    }
}
