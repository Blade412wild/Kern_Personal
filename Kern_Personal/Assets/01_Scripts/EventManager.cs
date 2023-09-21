using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventManager<T>
{
    private static Dictionary<EventType, System.Action<T>>
    eventDictionary = new Dictionary<EventType, System.Action<T>>();

    public static void AddListner(EventType type, System.Action<T> function)
    {
        if (!eventDictionary.ContainsKey(type))
        {
            eventDictionary.Add(type, null);
        }
        eventDictionary[type] += function;
    }

    public static void RemoveListner(EventType type, System.Action<T> function)
    {
        if (!eventDictionary.ContainsKey(type) && eventDictionary[type] != null)
        {
            eventDictionary[type] -= function;
        }
    }

    public static void RaiseEvent(EventType type, T arg1)
    {
        eventDictionary[type]?.Invoke(arg1);
    }



}
