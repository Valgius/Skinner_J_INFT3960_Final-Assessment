using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectDesScript : MonoBehaviour
{
    private Score scoreManager;
    public int scoreValue;


    void Start()
    {
        scoreManager = FindObjectOfType<Score> ();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            scoreManager.AddCollect(scoreValue);
            Destroy(gameObject);
        }
    }

}