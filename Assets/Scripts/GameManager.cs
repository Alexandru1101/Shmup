using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject enemyPrefab;
    public GameObject gameOverPanel;
    public GameObject PauseScreen;
    bool isPaused=false;
    public GameObject swarmPrefab;
    public TextMeshProUGUI scoreText;
    private int score;
    public bool isGameActive;
    public Button restartButton;
    void Start()
    {
        isGameActive=true;
        InvokeRepeating("SpawnEnemies",1,1.5f);
        InvokeRepeating("SpawnSwarm",5,2.5f);
        score=0;
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {   if(Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }

        if(isGameActive==false)
            CancelInvoke();

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

    public void Pause()
    {
        
         
             
             if(isPaused)
                {
                    Time.timeScale = 1;
                    isPaused=!isPaused;
                    PauseScreen.gameObject.SetActive(false);

                }
            else
                {
                Time.timeScale = 0;
                isPaused=!isPaused;
                PauseScreen.gameObject.SetActive(true);
                }




         
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void RestartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
