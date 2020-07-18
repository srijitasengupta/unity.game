using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameSpace : MonoBehaviour
{
    
    [Range(0.1f, 10f)] [SerializeField] float gamespeed;
    [SerializeField] int score = 0;
    [SerializeField] TextMeshProUGUI scoretext;
    
  


    private void Awake()
    {
        int gamespacecount = FindObjectsOfType<GameSpace>().Length;

        if (gamespacecount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }


    void Start()
    {
        scoretext.text = "SCORE!";
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gamespeed;
        
    }
    public void CalScore()
    {
        score = score + 5;
        scoretext.text = score.ToString();
    }
    public void ResetGame()
    {
        Destroy(gameObject);
    }
   
}
