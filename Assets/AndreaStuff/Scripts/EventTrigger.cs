using UnityEngine;
using UnityEngine.Events;

public class EventTrigger : MonoBehaviour
{
    [System.Serializable]
    public class EventTime
    {
        public float timeInSeconds;
        public UnityEvent unityEvent;
    }

    public EventTime[] eventTimes;

    private void Update()
    {
        foreach (var eventTime in eventTimes)
        {
            if (Mathf.Approximately(eventTime.timeInSeconds, Time.time))
            {
                eventTime.unityEvent.Invoke();
            }
        }
    }
}
