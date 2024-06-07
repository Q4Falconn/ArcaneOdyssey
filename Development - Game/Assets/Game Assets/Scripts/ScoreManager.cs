using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI winText;
    [SerializeField] TextMeshProUGUI startingText;
    [SerializeField] TextMeshProUGUI endingText;

    [SerializeField] GameObject targetObject;

    int score;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score + " / 6";

        winText.gameObject.SetActive(false);
        targetObject.SetActive(false);
        endingText.gameObject.SetActive(false);

        startingText.gameObject.SetActive(true);
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score + " / 6";


        if (score >= 1)
        {
            startingText.gameObject.SetActive(false);
        }

        if (score >= 6)
        {
            scoreText.gameObject.SetActive(false);
            endingText.gameObject.SetActive(true);
            targetObject.SetActive(true);
        }
    }
}
