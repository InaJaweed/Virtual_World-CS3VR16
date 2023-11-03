using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    private AddNumber numberScript;

    private void Start()
    {
        numberScript = GetComponent<AddNumber>();
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        numberScript.AddValue();

        Destroy(gameObject);
    }
 
}
