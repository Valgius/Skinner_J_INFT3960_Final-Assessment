using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscenetransition : MonoBehaviour
{
    public int CutSceneNum;

    //https://www.youtube.com/watch?v=NnPDJfvLeWQ //tutorial Location


    // Start is called before the first frame update
    void OnEnable() //Tutorial Coding Line
    {
        if (CutSceneNum == 1)
        {
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        }

        if (CutSceneNum == 2)
        {
            SceneManager.LoadScene("WinScene1", LoadSceneMode.Single); //Tutorial Coding Line, string edited.
        }

        if (CutSceneNum == 3)
        {
        SceneManager.LoadScene("WinScene2", LoadSceneMode.Single);
        }

        if (CutSceneNum == 4)
        {
            SceneManager.LoadScene("WinScene3", LoadSceneMode.Single);
        }
    }

}
