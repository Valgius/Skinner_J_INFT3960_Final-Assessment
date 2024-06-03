using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public int LevelNum;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (LevelNum == 1)
            {
                SceneManager.LoadScene("Cutscene2", LoadSceneMode.Single);
            }

            if (LevelNum == 2)
            {
                SceneManager.LoadScene("Cutscene3", LoadSceneMode.Single);
            }

            if (LevelNum == 3)
            {
                SceneManager.LoadScene("Cutscene4", LoadSceneMode.Single);
            }
        }
    }

}
