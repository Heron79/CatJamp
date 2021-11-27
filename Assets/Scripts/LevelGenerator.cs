using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public int numberOfPlatform;
    public float minY ;
    public float maxY ;
    public GameObject platformPrefab;
    public float levelWidth;
    public Vector3 _spawnPosition ;
    void Start()
    {

        SpawnPlatform(platformPrefab, _spawnPosition, numberOfPlatform, 5);

    }
    private void SpawnPlatform(GameObject prefab, Vector3 startPos,int numberOfObject,int frequence)
    {
        for (int i = 0;numberOfObject >= 0;i++)
        {


            startPos.y += Random.Range(minY, maxY);
            if (i % frequence == 0)
            {
                startPos.x = Random.Range(-levelWidth, levelWidth);
                Instantiate(prefab, startPos, Quaternion.identity);
                numberOfObject--;
                //Debug.LogError("Платформа № "+i);
            } 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
