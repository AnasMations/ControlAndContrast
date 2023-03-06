using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeEvents : MonoBehaviour
{
    public List<timedEvent> events;

    void Start()
    {
        foreach (timedEvent e in events)
        {
            if (e.playOnStart)
            {
                StartCoroutine(e.ExecuteAfterTime(e.waitTimeInMinutes));
            }
        }
    }

    public void ExecuteEvent(string eventName)
    {
        foreach (timedEvent e in events)
        {
            if (e.eventName == eventName)
            {
                StartCoroutine(e.ExecuteAfterTime(e.waitTimeInMinutes));
            }
        }
    }


}

[Serializable]
public class timedEvent
{
    public string eventName;
    public float waitTimeInMinutes;
    public bool playOnStart = false;
    public UnityEvent unityEvent;

    public IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time * 60);
        unityEvent.Invoke();
    }
}