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
            Debug.LogWarning(i);
            
        }
        Debug.LogError("Об'єкт буде вилучено через 4 секунди!");
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
