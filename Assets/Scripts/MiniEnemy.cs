using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniEnemy : MonoBehaviour
{
    // Start is called before the first frame update

    private GameManager gameManager;
    public GameObject explosionAnim;
    public GameObject soundController;
    void Start()
    {
        
        gameManager=GameObject.Find("GameManager").GetComponent<GameManager>();
        soundController=GameObject.Find("SoundManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
         if(other.gameObject.CompareTag("Bullet"))
         {  

             gameManager.UpdateScore(1);
             Instantiate(explosionAnim,transform.position,transform.rotation);
             soundController.GetComponent<SoundController>().ExplosionEnemy();   
             Destroy(gameObject);
         }
    }
}

