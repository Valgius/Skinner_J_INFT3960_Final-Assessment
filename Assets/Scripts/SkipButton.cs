using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipButton : MonoBehaviour
{

    public void CutScene1()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
    public void Cutscene2()
    {
        SceneManager.LoadScene("WinScene1", LoadSceneMode.Single);
    }
    public void Cutscene3()
    {
        SceneManager.LoadScene("WinScene2", LoadSceneMode.Single);
    }
    public void Cutscene4()
    {
        SceneManager.LoadScene("WinScene3", LoadSceneMode.Single);
    }
}
