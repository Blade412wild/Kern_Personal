using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    private FSM fsm;
    // Start is called before the first frame update
    void Start()
    {
        fsm = new FSM(typeof(SleepState), GetComponents<BaseState>());
    }

    // Update is called once per frame
    void Update()
    {
        fsm.OnUpdate();
    }
}
