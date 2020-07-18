using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    [SerializeField] int totalblocks;

    SceneLoader sceneloader;

   
    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }
    public void CountBlocks()
    {
        totalblocks++;
    }
    public void CountdestroyedBlocks()
    {
        totalblocks--;
        if(totalblocks==0)
        {
            sceneloader.LoadScene();
        }
    }
}
