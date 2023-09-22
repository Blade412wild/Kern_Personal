using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using static UnityEngine.UI.GridLayoutGroup;

public abstract class WorkerBase : MonoBehaviour
{
    //public int[] workHours = { 9, 10, 11, 12, 13, 14, 15, 16, 17 };
    //public int[] SleepHours = { 22, 0, 1, 2, 3, 4, 5, 6, 7 };
    //public int[] ToWorkHours = { 8 };
    //public int[] ToHomeHours = { 18, 19, 20, 21 };

    //private int beginWorkHours;
    //private int endWorkHours;
    //private int beginSleepHours;
    //private int endSleepHours;
    //private int beginToWorkHours;
    //private int endToWorkHours;
    //private int beginToHomeHours;
    //private int endToHomeHours;

    //private int index;
    //private void Start()
    //{
    //    HourEventDecider();
    //    HoursShower();
    //}

    public virtual void Sleeping()
    {
        Debug.Log( transform.name + "sleeping");
    }
    public virtual void Working()
    {
        Debug.Log(transform.name + "working");
    }

    public virtual void ToWork()
    {
        Debug.Log(transform.name + "ToWork");
    }

    public virtual void ToHome()
    {
        Debug.Log(transform.name + "ToHome");
    }

    //private void HourEventDecider()
    //{
    //    index = 0;
    //    // hier bepaal ik via index 0 wat de begin uren zijn voor de werkers
    //    beginWorkHours = workHours[index];
    //    beginSleepHours = SleepHours[index];
    //    beginToHomeHours = ToHomeHours[index];
    //    beginToWorkHours = ToWorkHours[index];

    //    // hier bepaal ik via lenght van de array wat de eind uren zijn voor de werkers
    //    index = workHours.Length;
    //    endToWorkHours = workHours[index];

    //    index = SleepHours.Length;
    //    endSleepHours = SleepHours[index];
        
    //    index = ToWorkHours.Length;
    //    endToWorkHours = ToWorkHours[index];

    //    index = ToHomeHours.Length;
    //    endSleepHours = ToWorkHours[index];

    //}

    //private void HoursShower()
    //{
    //    Debug.Log(transform.name + " begint met werken op " + beginWorkHours + " uur ");
    //    Debug.Log(transform.name + " gaat naar huis op  " + beginToHomeHours + " uur");
    //    Debug.Log(transform.name + " gaat naar werk op " + beginToWorkHours + " uur");
    //    Debug.Log(transform.name + " begint met slapen op " + beginSleepHours + " uur");
    //}



}
