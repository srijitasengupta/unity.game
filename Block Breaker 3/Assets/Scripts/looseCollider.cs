using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class looseCollider : MonoBehaviour
{
    [SerializeField] int lives = 3;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (tag == "LooseCollider")
        {
            lives--;
            if (lives == 2)
            {
                FindObjectOfType<Chance3>().Chance3Function();
            }
            else if(lives==1)
            {
                FindObjectOfType<Chance2>().Chance2Function();
            }
            else if(lives==0)
            {
                FindObjectOfType<Chance1>().Chance1Function();
                SceneManager.LoadScene("Game Over");
                
            }

            
         
        }
    }



}
