using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //https://www.c-sharpcorner.com/article/create-start-menu-scene-using-c-sharp-script-in-unity-3d/ 


    public void PlayGame()
    {
        SceneManager.LoadScene("Cutscene1");
    }
    public void QuitGame ()
        {
        Debug.Log("QUIT");
        SceneManager.LoadScene("Quit");
    }
}
