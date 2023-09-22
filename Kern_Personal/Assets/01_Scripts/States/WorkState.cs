using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkState : BaseState
{
    public override void OnEnter()
    {
        
    }

    public override void OnExit()
    {
        owner.SwitchState(typeof(StateToHome));

    }

    public override void OnUpdate()
    {

    }
}
