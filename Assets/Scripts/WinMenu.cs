using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public int Level;


    public void ExitLevel()
    {
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
    }
    public void ReplayLevel()
    {
        if (Level == 1)
        {
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        }

        if (Level == 2)
        {
            SceneManager.LoadScene("Level2", LoadSceneMode.Single);
        }

        if (Level == 3)
        {
            SceneManager.LoadScene("Level3", LoadSceneMode.Single);
        }
    }
    public void NextLevel()
    {
        if (Level == 1)
        {
            SceneManager.LoadScene("Level2", LoadSceneMode.Single);
        }

        if (Level == 2)
        {
            SceneManager.LoadScene("Level3", LoadSceneMode.Single);
        }
    }



}
