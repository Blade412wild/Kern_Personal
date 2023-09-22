using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/WorkerData")]
public class WorkerData : ScriptableObject
{
    public int[] WorkHours = { };
    public int[] SleepHours = { };
    public int[] ToWorkHours = { };
    public int[] ToHomeHours = { };
}
