using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankStopWorker : WorkerBase
{
    public int[] workHours = { 22, 23, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7 };
    public int[] SleepHours = { 10, 11, 12, 13, 14, 15, 16, 17 };
    public int[] ToWorkHours = { 18, 19, 20 };
    public int[] ToHomeHours = { 8, 9 };
    private void OnEnable()
    {
        HoursManager.Hour22 += Working;
        HoursManager.Hour7 -= Working;

        HoursManager.Hour10 += Sleeping;
        HoursManager.Hour17 -= Sleeping;

        HoursManager.Hour18 += ToWork;
        HoursManager.Hour20 -= ToWork;

        HoursManager.Hour8 += ToHome;
        HoursManager.Hour9 -= ToHome;
    }
    //public override void Sleeping()
    //{
    //    SleepHours[0].ToString();
    //    Debug.Log(transform.name + " eerste slaap uur is = " + SleepHours[0]);
    //}
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
}
