using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip explosionSound;
    private AudioSource soundSource;

    public AudioClip shootSound;


    void Start()
    {
        soundSource=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExplosionEnemy()
    {
       soundSource.PlayOneShot(explosionSound,0.5f);
    }

    public void ShootSound()
    {
        soundSource.PlayOneShot(shootSound,0.5f);
    }
}
