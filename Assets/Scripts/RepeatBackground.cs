using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    // Start is called before the first frame update

  Vector2 startPos;
  private float repeat=95;

    void Start()
    {
        startPos=transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.down*0.05f);
        if(transform.position.y<startPos.y-repeat)
            {
                transform.position=startPos;
            }
    }
}
