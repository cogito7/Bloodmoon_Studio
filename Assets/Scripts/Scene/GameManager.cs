using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timeRemaining = 91f;
    private int score;

    public TextMeshProUGUI healthDisplay;
    public TextMeshProUGUI scoreDisplay;
    public TextMeshProUGUI timerDisplay;
    

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreDisplay.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        TimerUpdate();
    }

    public void HealthUpdate()
    {

    }

    public void ScoreUpdate(int scoreCount)
    {
        score = score + scoreCount;
        scoreDisplay.text = "Score: " + score;
    }

    public void TimerUpdate()
    {
        //if (m_IsPlayerAtExit || m_IsPlayerCaught)
        //    return;

        timeRemaining -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);

        timerDisplay.text = string.Format("TIME: {0:00}:{1:00}", minutes, seconds);
    }
}
