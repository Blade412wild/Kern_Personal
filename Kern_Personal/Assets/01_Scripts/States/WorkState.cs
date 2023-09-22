using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkState : BaseState
{
    public override void OnEnter()
    {
        transform.position = new Vector3(-1, transform.position.y, transform.position.z);

        Debug.Log(transform.name + "working");
    }

    public override void OnExit()
    {

    }

    public override void OnUpdate()
    {

    }
}
