using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{ 
    public float speed = 100f;
private Transform _target;
void Start()
{
<<<<<<< Updated upstream
    _target = FindObjectOfType<Player>().GetComponent<Transform>();
}
=======
    public float speed = 100f;
    private Transform _target;
    void Start()
    {
        _target = FindObjectOfType<Player>().GetComponent<Transform>();
    }
>>>>>>> Stashed changes

// Update is called once per frame
void Update()
{
    if (_target.position.y > gameObject.transform.position.y)
    {
<<<<<<< Updated upstream
        Vector3 newPos = new Vector3(transform.position.x, _target.position.y, transform.position.z);
        gameObject.transform.position = Vector3.Lerp(transform.position, newPos, speed);
=======
        if(_target.position.y> gameObject.transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, _target.position.y, transform.position.z);
            gameObject.transform.position = Vector3.Lerp(transform.position, newPos, speed);
        }
>>>>>>> Stashed changes
    }
}
}
