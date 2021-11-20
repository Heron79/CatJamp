using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{

    private float movementSpeed = 10f;
    private float _directionMove;
    private Rigidbody2D _playerRB;
   


    void Start()
    {
        _playerRB = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {

        _directionMove = Input.GetAxisRaw("Horizontal") * movementSpeed;//10f /-10f
        
    }
    private void FixedUpdate()
    {
        Vector2 velocity = _playerRB.velocity;//x=0,y=-5
        velocity.x = _directionMove;//10f/-10f
        _playerRB.velocity = velocity;
    
        _directionMove = Input.GetAxis("Horizontal") * movementSpeed;
    }

}
