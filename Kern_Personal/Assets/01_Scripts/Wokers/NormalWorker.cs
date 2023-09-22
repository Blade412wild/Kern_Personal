using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalWorker : WorkerBase
{
    public int[] workHours = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
    public int[] SleepHours = { 21, 22, 0, 1, 2 };
    public int[] ToWorkHours = { 3, 4 };
    public int[] ToHomeHours = { 18, 19, 20 };

    private int beginWorkHours;
    private int endWorkHours;
    private int beginSleepHours;
    private int endSleepHours;
    private int beginToWorkHours;
    private int endToWorkHours;
    private int beginToHomeHours;
    private int endToHomeHours;

    private int index;
    private void Start()
    {
        HourEventDecider();
        HoursShower();
    }

    private void OnEnable()
    {
        HoursManager.Hour5 += Working;
        HoursManager.Hour17 -= Working;

        HoursManager.Hour21 += Sleeping;
        HoursManager.Hour2 -= Sleeping;

        HoursManager.Hour3 += ToWork;
        HoursManager.Hour4 -= ToWork;

        HoursManager.Hour18 += ToHome;
        HoursManager.Hour20 -= ToHome;
    }
    public override void Sleeping()
    {
        transform.position = new Vector3(-15, transform.position.y, transform.position.z);
        Debug.Log(transform.name + "sleeping");
    }

    public override void Working()
    {
        transform.position = new Vector3(-1, transform.position.y, transform.position.z);

        Debug.Log(transform.name + "working");
    }

    public override void ToWork()
    {
        transform.position = new Vector3(-8, transform.position.y, transform.position.z);

        Debug.Log(transform.name + "ToWork");
    }

    public override void ToHome()
    {
        transform.position = new Vector3(6, transform.position.y, transform.position.z);
        Debug.Log(transform.name + "ToHome");

    }
    private void HourEventDecider()
    {
        index = 0;
        // hier bepaal ik via index 0 wat de begin uren zijn voor de werkers
        beginWorkHours = workHours[index];
        beginSleepHours = SleepHours[index];
        beginToHomeHours = ToHomeHours[index];
        beginToWorkHours = ToWorkHours[index];

        // hier bepaal ik via lenght van de array wat de eind uren zijn voor de werkers
        //index = workHours.Length;
        //endToWorkHours = workHours[index];

        //index = SleepHours.Length;
        //endSleepHours = SleepHours[index];

        //index = ToWorkHours.Length;
        //endToWorkHours = ToWorkHours[index];

        //index = ToHomeHours.Length;
        //endSleepHours = ToWorkHours[index];

    }

    private void HoursShower()
    {
        Debug.Log(transform.name + " begint met werken op " + beginWorkHours + " uur ");
        Debug.Log(transform.name + " gaat naar huis op  " + beginToHomeHours + " uur");
        Debug.Log(transform.name + " gaat naar werk op " + beginToWorkHours + " uur");
        Debug.Log(transform.name + " begint met slapen op " + beginSleepHours + " uur");
    }

}
