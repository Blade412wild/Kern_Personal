using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateToHome : BaseState
{
    public override void OnEnter()
    {
        transform.position = new Vector3(6, transform.position.y, transform.position.z);
        Debug.Log(transform.name + "ToHome");
    }

    public override void OnExit()
    {

    }

    public override void OnUpdate()
    {

    }
}
