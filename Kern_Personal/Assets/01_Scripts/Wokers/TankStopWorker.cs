using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankStopWorker : WorkerBase
{
    
    private void OnEnable()
    {
        //HoursManager.Hour22 += Working;
        //HoursManager.Hour7 -= Working;

        //HoursManager.Hour10 += Sleeping;
        //HoursManager.Hour17 -= Sleeping;

        //HoursManager.Hour18 += ToWork;
        //HoursManager.Hour20 -= ToWork;

        //HoursManager.Hour8 += ToHome;
        //HoursManager.Hour9 -= ToHome;
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
