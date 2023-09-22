using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateToWork : BaseState
{
    public override void OnEnter()
    {

    }

    public override void OnExit()
    {
        owner.SwitchState(typeof(WorkState));

    }

    public override void OnUpdate()
    {

    }

}
