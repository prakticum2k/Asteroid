using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb2d;
    private Vector2 moveInput;
    public GameObject gameOverText, restartButton;

    // Start is called before the first frame update
    void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        transform.up = direction;

        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();
        rb2d.velocity = moveInput * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
        if (collision.gameObject.tag.Equals("rock"))
            if (collision.gameObject.tag.Equals("cam"))
            {
                gameOverText.SetActive(true); restartButton.SetActive(true);
            }
        {
            gameOverText.SetActive(true); restartButton.SetActive(true);
        }
    }
}
