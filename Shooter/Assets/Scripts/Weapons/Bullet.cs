using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    private int damage;

    public void Setup(int damage) {
        this.damage = damage;
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
    
    

    private void OnCollisionEnter(Collision other) 
    {
        if(other != null) 
        {
            Destroy(gameObject);
        }   
    }

    void OnTriggerEnter(Collider other)
    {   
        
        Destroy(gameObject);
        if (other.gameObject.tag == "Enemy") 
        {
            other.gameObject.GetComponent<Enemy>().TakeDamage(damage);
        }
    }
}
