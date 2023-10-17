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
        score += Time.deltaTime * scoreMultiplier; //Her hayatta kalan saniyeyi önceki saniyeler ile toplayacak.
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    private void OnDestroy()  //en yüksek score u kaydediyor.
    {
        //int currentHighScore = PlayerPrefs.GetInt("HighScore", 0);
        int currentHighScore = PlayerPrefs.GetInt(HighScoreKey, 0);

        if(score > currentHighScore)
        {  
            //PlayerPrefs.SetInt("HighScore", Mathf.FloorToInt(score));
            PlayerPrefs.SetInt(HighScoreKey, Mathf.FloorToInt(score));        
        }
    }
}

