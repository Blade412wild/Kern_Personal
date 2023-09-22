using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using static UnityEngine.UI.GridLayoutGroup;

public class SleepState : BaseState
{
    public override void OnEnter()
    {
        transform.position = new Vector3(-15, transform.position.y, transform.position.z);
        Debug.Log(transform.name + "sleeping");


    }

    public override void OnExit()
    {

    }

    public override void OnUpdate()
    {

    }

}
