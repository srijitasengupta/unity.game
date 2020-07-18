using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
  public void LoadScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void LoadStartScene()
    {
        FindObjectOfType<GameSpace>().ResetGame();
        SceneManager.LoadScene(0);
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
