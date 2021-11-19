using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
<<<<<<< Updated upstream
    private float movementSpeed = 10f;
    private float _directionMove;
    private Rigidbody2D _playerRB;
    // Start is called before the first frame update
    void Start()
    {
        _playerRB = GetComponent<Rigidbody2D>(); 
=======
    public float _movementSpeed = 20f;
    private float _directionMove;
    private Rigidbody2D _playerRB;

    void Start()
    {
        _playerRB = GetComponent<Rigidbody2D>();
>>>>>>> Stashed changes
    }

    void Update()
    {
<<<<<<< Updated upstream
        _directionMove = Input.GetAxisRaw("Horizontal") * movementSpeed;
        
    }
    private void FixedUpdate()
    {
        Vector2 velocity = _playerRB.velocity;
        velocity.x = _directionMove;
        _playerRB.velocity = velocity;
    }
=======
        _directionMove = Input.GetAxis("Horizontal") * _movementSpeed;
    }
    private void FixedUpdate()
    {
        Vector2 velik = _playerRB.velocity;
        velik.x = _directionMove;
        _playerRB.velocity = velik;

    }
    
>>>>>>> Stashed changes
}
