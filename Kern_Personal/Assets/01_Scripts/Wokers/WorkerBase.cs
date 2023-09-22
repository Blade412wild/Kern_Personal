using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using static UnityEngine.UI.GridLayoutGroup;

public abstract class WorkerBase : MonoBehaviour
{
    public WorkerData WorkerData;

    private int beginWorkHours;
    private int endWorkHours;
    private int beginSleepHours;
    private int endSleepHours;
    private int beginToWorkHours;
    private int endToWorkHours;
    private int beginToHomeHours;
    private int endToHomeHours;

    private FSM fsm;

    private void OnEnable()
    {
    }

    private void Start()
    {
        HoursManager.OndingDong += EventHourSubscriber;
        fsm = new FSM(typeof(SleepState), GetComponents<BaseState>());
        HourDecider();
        //HoursShower();
    }

    public virtual void Sleeping()
    {
        Debug.Log(transform.name + "sleeping");
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

    private void HourDecider()
    {
        beginWorkHours = WorkerData.WorkHours[0];
        endWorkHours = WorkerData.WorkHours[1];

        beginSleepHours = WorkerData.SleepHours[0];
        endSleepHours = WorkerData.SleepHours[1];

        beginToHomeHours = WorkerData.ToHomeHours[0];
        endToHomeHours = WorkerData.ToHomeHours[1];

        beginToWorkHours = WorkerData.ToWorkHours[0];
        endToWorkHours = WorkerData.ToWorkHours[1];

    }
    //private void HoursShower()
    //{
    //    Debug.Log(transform.name + " begint met werken op " + beginWorkHours + " uur ");
    //    Debug.Log(transform.name + " gaat naar huis op  " + beginToHomeHours + " uur");
    //    Debug.Log(transform.name + " gaat naar werk op " + beginToWorkHours + " uur");
    //    Debug.Log(transform.name + " begint met slapen op " + beginSleepHours + " uur");
    //}

    private void EventHourSubscriber(int hour)
    {
        Debug.Log("eventHoursubec  " + hour );
        if (hour == beginWorkHours)
        {
            fsm.SwitchState(typeof(WorkState));
        }

        if (hour == beginToHomeHours)
        {
            fsm.SwitchState(typeof(StateToHome));
        }

        if (hour == beginToWorkHours)
        {
            fsm.SwitchState(typeof(StateToWork));

        }
        if (hour == beginSleepHours)
        {
            fsm.SwitchState(typeof(SleepState));
        }
    }
}
