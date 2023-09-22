using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateToWork : BaseState
{
    public override void OnEnter()
    {
        transform.position = new Vector3(-8, transform.position.y, transform.position.z);

        Debug.Log(transform.name + "ToWork");
    }

    public override void OnExit()
    {

    }

    public override void OnUpdate()
    {

    }

}
