using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour, IDamageable
{
    private float health;
    public float Health { get { return health; } }
    public void SetHealth(float h) { health = h; }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
    }

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
