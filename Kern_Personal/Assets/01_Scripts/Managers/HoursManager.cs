using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HoursManager : MonoBehaviour
{
    public delegate void Hours(int hour);
    public static event Hours dingDong;

    //Hours[] ArrayDayHours = { Hour1, Hour2, Hour3, Hour4, Hour6, Hour7, Hour8, Hour9, Hour10, Hour11, Hour12, Hour13, Hour14, Hour15, Hour16, Hour17, Hour18};
    //Hours[] ArrayDayHours = { Hour1 };
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

        //ArrayDayHours[0]?.ToString();
        //Debug.Log(ArrayDayHours[0]?.ToString());
    }

    private void EventRaiser(int hour)
    {
        dingDong?.Invoke(hour);
        //EventManager.RaiseEvent(NEXT_HOUR);
    }
}
