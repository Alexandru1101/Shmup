using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniEnemy : MonoBehaviour
{
    // Start is called before the first frame update

    private GameManager gameManager;
    void Start()
    {
        
        gameManager=GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
         if(other.gameObject.CompareTag("Bullet"))
         {  

             gameManager.UpdateScore(1);
             Destroy(gameObject);
         }
    }
}

