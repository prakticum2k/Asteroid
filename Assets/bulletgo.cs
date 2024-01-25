using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletgo : MonoBehaviour
{
    public float speed;
    public float lifetime = 2f;
    public float player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.TryGetComponent<enemyhealth>(out enemyhealth enemyComponent))
        {
            enemyComponent.TakeDamage(1);
        }
        Destroy(gameObject);
    }
    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("playerrr");
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }
    private void Awake()
    {
        
        Destroy(gameObject, lifetime);

    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed );
    }
}
