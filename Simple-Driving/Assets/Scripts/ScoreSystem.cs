using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultiplier;

    private float score;
    public const string HighScoreKey = "HighScore";

    void Update()
    {
        score += Time.deltaTime * scoreMultiplier; //Her hayatta kalan saniyeyi �nceki saniyeler ile toplayacak.
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    private void OnDestroy()  //en y�ksek score u kaydediyor.
    {
        //int currentHighScore = PlayerPrefs.GetInt("HighScore", 0);
        int currentHighScore = PlayerPrefs.GetInt(HighScoreKey);

        if(score > currentHighScore)
        {  
            //PlayerPrefs.SetInt("HighScore", Mathf.FloorToInt(score));
            PlayerPrefs.SetInt(HighScoreKey, Mathf.FloorToInt(score));        
        }
    }
}

