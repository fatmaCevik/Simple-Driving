using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultiplier;

    private float score;


    void Update()
    {
        score += Time.deltaTime * scoreMultiplier; //Her hayatta kalan saniyeyi önceki saniyeler ile toplayacak.
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }
}
