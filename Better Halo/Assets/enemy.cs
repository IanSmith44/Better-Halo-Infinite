using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemy : MonoBehaviour
{

    public float health = 50f;


    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }
    void Update ()
    {
        if (transform.position.y < -3) {
            Destroy(gameObject);
        }
    }
    void Die ()
    {
        Destroy(gameObject);
    }
}
