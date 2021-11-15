using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { for(int i = 1; i <= 20; i += 2)
        {
            Debug.LogError(i);
            
        }
        Debug.LogError("Об'єкт буде вилучено через 4 секунди!");
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
