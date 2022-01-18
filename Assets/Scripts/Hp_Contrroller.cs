using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp_Contrroller : MonoBehaviour
{
    // Start is called before the first frame update



    int hp=3;
    public GameObject player;
    
    private Image healthImg;
    public Sprite[] healthSprites;
    void Start()
    {       
        healthImg=gameObject.GetComponent<Image>();
    }
    // Update is called once per frame
    void Update()


    {   
        hp=player.GetComponent<PlayerController>().hp;
        if(hp==0)
          {
              gameObject.SetActive(false);
          }
        
            healthImg.sprite=healthSprites[hp];
        
    

    }
}
