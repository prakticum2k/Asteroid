using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdamage : MonoBehaviour
{

    
    public int bulletDamage;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "rock")
        {;
            object value = other.gameObject.GetComponent<enemyhealth>();
            Destroy(gameObject);
        }

    }

}
