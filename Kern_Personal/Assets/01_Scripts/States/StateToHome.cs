using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateToHome : BaseState
{
    public override void OnEnter()
    {

    }

    public override void OnExit()
    {
        owner.SwitchState(typeof(SleepState));

    }

    public override void OnUpdate()
    {

    }
}