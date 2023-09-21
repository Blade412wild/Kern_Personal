using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI second1;
    [SerializeField] private TextMeshProUGUI second2;
    [SerializeField] private TextMeshProUGUI seperator1;
    [SerializeField] private TextMeshProUGUI minutes1;
    [SerializeField] private TextMeshProUGUI minutes2;
    [SerializeField] private TextMeshProUGUI seperator2;
    [SerializeField] private TextMeshProUGUI hours1;
    [SerializeField] private TextMeshProUGUI hours2;

    private float timerDuration = 3 * 60f;
    private float timer;


    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            UpdateTimerDisplay(timer);
            timer -= Time.deltaTime;
        }
        else
        {
            Flash();
        }
    }

    private void ResetTimer()
    {
        timer = timerDuration;
    }

    private void UpdateTimerDisplay(float _timer)
    {
        float _minutes = Mathf.FloorToInt(timer / 60);
        float _seconds = Mathf.FloorToInt(timer % 60);

        string currentTime = string.Format("{00:00}{01:00}", _minutes, _seconds);
        minutes1.text = currentTime[0].ToString();
        minutes2.text = currentTime[1].ToString();
        second1.text = currentTime[2].ToString();
        second2.text = currentTime[3].ToString();

    }

    private void Flash()
    {


    }

}