using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject enemyPrefab;

    bool isPaused=false;
    
    public GameObject swarmPrefab;

    public TextMeshProUGUI scoreText;
    private int score;
    void Start()
    {
        InvokeRepeating("SpawnEnemies",1,1.5f);
        InvokeRepeating("SpawnSwarm",5,2.5f);
        score=0;
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {   
        Debug.Log(isPaused);
        if(Input.GetKeyDown(KeyCode.P))
         {   
             
             if(isPaused)
                Time.timeScale = 1;
            else
                Time.timeScale = 0;
                isPaused=!isPaused;




         }

    }

    void SpawnEnemies()
    {
        
        Vector2 spawnPosition=new Vector2(Random.Range(-10.0f,10.0f),10);
        Instantiate(enemyPrefab,spawnPosition,enemyPrefab.transform.rotation);
        
    }

    void SpawnSwarm()
    {
        Vector2 spawnPosition=new Vector2(Random.Range(-10.0f,10.0f),10);
        Instantiate(swarmPrefab,spawnPosition,enemyPrefab.transform.rotation);
    }

    public void UpdateScore(int scoreToAdd)
    {
        score+=scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
