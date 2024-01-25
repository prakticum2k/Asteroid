using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class enemyhealth : MonoBehaviour
{
    [SerializeField]float health, maxHealth = 10f;
    private void Start()
    {
        health = maxHealth;

    }
    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
