using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
   public static ScoreManager instance;
   private int_score = 0;
   public Text scoretext;


   private void Awake()
   {
    if (instance == null)
    {
        instance == this
    }
   }
   public void Addscore(int points)
   {
    _score += points;
    Debug.Log(_score);
    scoreText.text = "score : " + _score.ToString();
   }
}
