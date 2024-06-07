using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI winText;

    [SerializeField] GameObject targetObject;

    int score;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score + " / 6";

        winText.gameObject.SetActive(false);
        targetObject.SetActive(false);
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score + " / 6";

        if (score >= 6)
        {
            targetObject.SetActive(true);
        }
    }
}
