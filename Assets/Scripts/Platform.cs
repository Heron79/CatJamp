using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;
<<<<<<< Updated upstream
    private void OnCollisionEnter2D(Collision2D collision)
=======
    // Start is called before the first frame update
    void Start()
>>>>>>> Stashed changes
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (playerRb != null)
            {
                playerRb.velocity = Vector2.up * jumpForce;
                Destroy(gameObject, 5f);
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D playerRB = collision.gameObject.GetComponent<Rigidbody2D>();
            if (playerRB !=null)
            {
                playerRB.velocity = Vector2.up * jumpForce;
            }
        }
        
    }
}
