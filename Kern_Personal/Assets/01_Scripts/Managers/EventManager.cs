using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventManager
{
    public enum GameEvent
    {
        NEXT_HOUR,
    }

    private static Dictionary<GameEvent, System.Action>
    eventDictionary = new Dictionary<GameEvent, System.Action>();

    public static void AddListner(GameEvent type, System.Action function)
    {
        if (!eventDictionary.ContainsKey(type))
        {
            eventDictionary.Add(type, null);
        }
        eventDictionary[type] += function;
    }

    public static void RemoveListner(GameEvent type, System.Action function)
    {
        if (!eventDictionary.ContainsKey(type) && eventDictionary[type] != null)
        {
            eventDictionary[type] -= function;
        }
    }

    public static void RaiseEvent(GameEvent type)
    {
        eventDictionary[type]?.Invoke();
    }



}
