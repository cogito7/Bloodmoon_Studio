using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float time = 0;

    public TextMeshProUGUI healthDisplay;
    public TextMeshProUGUI scoreDisplay;
    public TextMeshProUGUI timerDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimerUpdate();
    }

    public void HealthUpdate()
    {

    }

    public void ScoreUpdate()
    {

    }

    public void TimerUpdate()
    {
        //if (m_IsPlayerAtExit || m_IsPlayerCaught)
        //    return;

        time += Time.deltaTime;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);

        timerDisplay.text = string.Format("TIME: {0:00}:{1:00}", minutes, seconds);
    }
}
