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
            StartCoroutine(e.ExecuteAfterTime(e.waitTime));
        }
    }


}

[Serializable]
public class timedEvent
{
    public float waitTime;
    public UnityEvent unityEvent;

    public IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        unityEvent.Invoke();
    }
}