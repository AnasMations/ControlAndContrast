using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{
    public float endTimeInMinutes = 0;
    public UnityEvent endEvent;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("End", endTimeInMinutes * 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void End()
    {
        endEvent.Invoke();
    }
}
