using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManagerOwn : MonoBehaviour
{
    [SerializeField] private Timer timer; 

    public delegate void TimerEvent();
    public static event TimerEvent OnTimerDone;

    // Start is called before the first frame update
    void Start()
    {
        //OnTimerDone.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
