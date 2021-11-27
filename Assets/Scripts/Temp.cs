using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        for(int i = 0; i <= 20; i+=5)
        {
            int X = 50;
            int Y = 10;
            Debug.Log(i);
            Add(X,Y);
            
        }
        Debug.Log("Об'єкт буде вилучено через 4 секунди!");
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Add(int A,int B)
    {
        Debug.Log(A + B);

    }
}
