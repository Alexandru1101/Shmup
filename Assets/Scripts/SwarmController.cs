using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmController : MonoBehaviour
{
    // Start is called before the first frame update

    int child;
    private GameManager gameManager;
    private float speed;
    void Start()
    {
        
        speed=Random.Range(7.0f,9.0f);
        gameManager=GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        child=transform.childCount;
        if(child==0)
        {
            gameManager.UpdateScore(3);
            Destroy(gameObject);

        }

        transform.Translate(Vector2.down*speed*Time.deltaTime);
    }
}
