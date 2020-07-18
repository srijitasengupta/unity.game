using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakingSound;
     Levels level;
    [SerializeField] GameObject particlevfx;
    [SerializeField] int maxhit;
    [SerializeField] Sprite[] sprites;
    int hitno=0;
    
    

    private void Start()
    {
        level = FindObjectOfType<Levels>();
       if(tag=="Breakable")
        {
            level.CountBlocks();
        }
        
       
    }

  

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (tag=="Breakable")
        {
            hitno++;
            if(hitno==maxhit)
            {
                DestroyBlocks();
            }
            else
            {
                int indexSprite = hitno - 1;
                GetComponent<SpriteRenderer>().sprite = sprites[indexSprite];
            }
        }
        
    }

    private void DestroyBlocks()
    {

        FindObjectOfType<GameSpace>().CalScore();
        AudioSource.PlayClipAtPoint(breakingSound, Camera.main.transform.position);
        Destroy(gameObject);
        level.CountdestroyedBlocks();
        ParticleBreakingVFX();

    }


    private void ParticleBreakingVFX()
    {
        GameObject sparkle = Instantiate(particlevfx, transform.position,transform.rotation);
        Destroy(sparkle, 2f);
    }
}
