using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp=2;
    public float speed;
    
    public GameObject soundController;
    private GameManager gameManager;
    public GameObject explosionAnim;
    void Start()
    {   
        soundController=GameObject.Find("SoundManager");
        speed=Random.Range(7.0f,10.0f);
        gameManager=GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down*speed*Time.deltaTime);

        if(hp==0)
            {    
                Instantiate(explosionAnim,transform.position,transform.rotation);      
                soundController.GetComponent<SoundController>().ExplosionEnemy();
                
                Destroy(gameObject);
                gameManager.UpdateScore(1);
            

            }


        if(transform.position.y<-10)
            Destroy(gameObject);
    }


      void OnCollisionEnter2D(Collision2D other) {
         if(other.gameObject.CompareTag("Bullet"))
         {
             hp--;
             
             
             
         }
     }
}
