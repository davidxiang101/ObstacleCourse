using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    int score = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            score++;
            Debug.Log("Score: " + score);
            Debug.Log("I hit: " + other.gameObject.name);
        }
    }
}
