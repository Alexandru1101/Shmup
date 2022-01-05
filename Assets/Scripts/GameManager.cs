using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject enemyPrefab;
    void Start()
    {
        InvokeRepeating("SpawnEnemies",1,2);
        
    }

    // Update is called once per frame
    void Update()
    {   

        
    }

    void SpawnEnemies()
    {
        
        Vector2 spawnPosition=new Vector2(Random.Range(-10.0f,10.0f),10);
        Instantiate(enemyPrefab,spawnPosition,enemyPrefab.transform.rotation);
        
    }
}
