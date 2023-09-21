using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] private float minutesInput;
    [SerializeField] private TextMeshProUGUI second1;
    [SerializeField] private TextMeshProUGUI second2;
    [SerializeField] private TextMeshProUGUI seperator1;
    [SerializeField] private TextMeshProUGUI minutes1;
    [SerializeField] private TextMeshProUGUI minutes2;
    [SerializeField] private TextMeshProUGUI seperator2;
    [SerializeField] private TextMeshProUGUI hours1;
    [SerializeField] private TextMeshProUGUI hours2;

    private float timerDuration;
    private float timer;

    public System.Action ActionTimerIsDone;

    public delegate void TimerEvent();
    public static event TimerEvent TimerIsDone;

    //public EventType TimerDone;

    // Start is called before the first frame update
    void Start()
    {
        //EventManager.AddListner(TimerDone, ActionTimerIsDone
        timerDuration = minutesInput * 60.0f;
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
        else if (timer <= 0)
        {
            TimerIsDone?.Invoke();
            ResetTimer();
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
