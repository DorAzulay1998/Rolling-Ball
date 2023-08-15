using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScript : MonoBehaviour
{
    public static TextScript instance;
    public GameObject starOne;
    public GameObject starTwo;
    public GameObject starThree;
    public bool finishLine;
    public TextMeshProUGUI scoreText;
    int score = 0;

    private void Awake()
    {
        instance = this;
        finishLine = false;
        starOne.SetActive(false);
        starTwo.SetActive(false);
        starThree.SetActive(false);
    }
    void Start()
    {
        scoreText.text = "Stars: ";
    }

    void Update()
    {
        if(finishLine == false)
        {
            scoreText.text = "Stars: " + score;
        }
        else
        {
            scoreText.text = "";
        }
    }

    public void AddScore()
    {
        score++;
    }

    public void DeleteText()
    {
        scoreText.text = "";
    }

    public void StarsSum()
    {
        if(score == 1)
        {
            starOne.SetActive(true);
        }
        if(score == 2)
        {
            starTwo.SetActive(true);
        }
        if(score == 3)
        {
            starThree.SetActive(true);
        }
    }
}
