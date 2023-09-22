using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalWorker : WorkerBase
{
    private void OnEnable()
    {
        //HoursManager.Hour5 += Working;
        //HoursManager.Hour17 -= Working;

        //HoursManager.Hour21 += Sleeping;
        //HoursManager.Hour2 -= Sleeping;

        //HoursManager.Hour3 += ToWork;
        //HoursManager.Hour4 -= ToWork;

        //HoursManager.Hour18 += ToHome;
        //HoursManager.Hour20 -= ToHome;
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

}
