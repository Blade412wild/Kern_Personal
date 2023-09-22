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

    private void Start()
    {

    }

}
