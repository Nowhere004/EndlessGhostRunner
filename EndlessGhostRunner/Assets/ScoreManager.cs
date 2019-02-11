using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public int score;
    public Text scoreDisplay;    
  
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Obstacle"))
        {
            score++;
            scoreDisplay.text = "Score: " + score.ToString();            
        }
    }
}
