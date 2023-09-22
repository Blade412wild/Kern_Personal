using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HoursManager : MonoBehaviour
{
    public delegate void Hours(int hour);
    public static event Hours OndingDong;

    private int counter;

    private void OnEnable()
    {
        Timer.TimerIsDone += Counter;
    }

    private void Counter()
    {
        counter++;
        Debug.Log(" het is " + counter + " uur");
        EventRaiser(counter);

        if (counter == 23)
        {
            counter = 0;
        }

    }

    private void EventRaiser(int hour)
    {
        OndingDong?.Invoke(hour);
    }

}
