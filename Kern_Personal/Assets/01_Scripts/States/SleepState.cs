using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using static UnityEngine.UI.GridLayoutGroup;

public class SleepState : BaseState
{
    public override void OnEnter()
    {
        owner.SwitchState(typeof(StateToHome));

    }

    public override void OnExit()
    {

    }

    public override void OnUpdate()
    {

    }

}
