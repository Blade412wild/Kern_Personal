using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using static UnityEngine.UI.GridLayoutGroup;

public class SleepState : BaseState
{
    public override void OnEnter()
    {

    }

    public override void OnExit()
    {
        owner.SwitchState(typeof(StateToWork));

    }

    public override void OnUpdate()
    {

    }

}
