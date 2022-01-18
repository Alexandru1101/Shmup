using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public int hp=3;
    public float horizontalInput;
    public float verticalInput;
    public float moveSpeed=15.0f;
    float yMin,yMax,xMin,xMax;





    public GameObject bullet;
    void Start()
    {


        var spriteSize = GetComponent<SpriteRenderer>().bounds.size.x * .5f; // Working with a simple box here, adapt to you necessity
 
         var cam = Camera.main;// Camera component to get their size, if this change in runtime make sure to update values
         var camHeight = cam.orthographicSize;
         var camWidth = cam.orthographicSize * cam.aspect;
 
         yMin = -camHeight + spriteSize; // lower bound
         yMax = camHeight - spriteSize; // upper bound
         
         xMin = -camWidth + spriteSize; // left bound
         xMax = camWidth - spriteSize; // right bound 



         InvokeRepeating ("Shoot",0,0.25f);
     }
    

    // Update is called once per frame
    void Update()
    {

        Move();
        if(hp==0)
        {
            Destroy(gameObject);
        }
       
         
    }


    void Move()
    {
        var ver = Input.GetAxisRaw("Vertical");
         var hor = Input.GetAxisRaw("Horizontal");
 

         var direction = new Vector2(hor, ver).normalized;
         direction *= moveSpeed * Time.deltaTime; 
 
         var xValidPosition = Mathf.Clamp(transform.position.x + direction.x, xMin, xMax);
         var yValidPosition = Mathf.Clamp(transform.position.y + direction.y, yMin, yMax);
 
         transform.position = new Vector3(xValidPosition, yValidPosition, 0f);
         

    }

    void Shoot()
    {
        Instantiate(bullet,transform.position,transform.rotation);
    }


    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Enemy"))
         {
             hp--;
             Destroy(other.gameObject);
         }
    }


 
}

