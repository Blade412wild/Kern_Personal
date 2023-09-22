using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoursManager : MonoBehaviour
{
    public delegate void Hours();
    public static event Hours Hour0;
    public static event Hours Hour1;
    public static event Hours Hour2;
    public static event Hours Hour3;
    public static event Hours Hour4;
    public static event Hours Hour5;
    public static event Hours Hour6;
    public static event Hours Hour7;
    public static event Hours Hour8;
    public static event Hours Hour9;
    public static event Hours Hour10;
    public static event Hours Hour11;
    public static event Hours Hour12;
    public static event Hours Hour13;
    public static event Hours Hour14;
    public static event Hours Hour15;
    public static event Hours Hour16;
    public static event Hours Hour17;
    public static event Hours Hour18;
    public static event Hours Hour19;
    public static event Hours Hour20;
    public static event Hours Hour21;
    public static event Hours Hour22;
    public static event Hours Hour23;

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
        switch (hour)
        {
            case 0: Hour0?.Invoke(); break;
            case 1: Hour1?.Invoke(); break;
            case 2: Hour2?.Invoke(); break;
            case 3: Hour3?.Invoke(); break;
            case 4: Hour4?.Invoke(); break;
            case 5: Hour5?.Invoke(); break;
            case 6: Hour6?.Invoke(); break;
            case 7: Hour7?.Invoke(); break;
            case 8: Hour8?.Invoke(); break;
            case 9: Hour9?.Invoke(); break;
            case 10: Hour10?.Invoke(); break;
            case 11: Hour11?.Invoke(); break;
            case 12: Hour12?.Invoke(); break;
            case 13: Hour13?.Invoke(); break;
            case 14: Hour14?.Invoke(); break;
            case 15: Hour15?.Invoke(); break;
            case 16: Hour16?.Invoke(); break;
            case 17: Hour17?.Invoke(); break;
            case 18: Hour18?.Invoke(); break;
            case 19: Hour19?.Invoke(); break;
            case 20: Hour20?.Invoke(); break;
            case 21: Hour21?.Invoke(); break;
            case 22: Hour22?.Invoke(); break;
            case 23: Hour23?.Invoke(); break;

            default: Debug.Log(" SwitchCase error"); break;

        }
    }
}
