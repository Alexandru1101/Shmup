using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    float speed=20.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up*speed*Time.deltaTime);
    }


    void OnBecameInvisible() {
         Destroy(gameObject);
     }

    void OnCollisionEnter2D(Collision2D other) {
         if(other.gameObject.CompareTag("Enemy"))
         {
             Destroy(gameObject);
         }

     }
}
