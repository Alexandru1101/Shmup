using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject enemyPrefab;

    public TextMeshProUGUI scoreText;
    private int score;
    void Start()
    {
        InvokeRepeating("SpawnEnemies",1,1.5f);
        score=0;
        
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

    public void UpdateScore(int scoreToAdd)
    {
        score+=scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
