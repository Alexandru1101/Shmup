using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    float speed=7;
    public int hp=2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down*speed*Time.deltaTime);

        if(hp==0)
            Destroy(gameObject);


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
