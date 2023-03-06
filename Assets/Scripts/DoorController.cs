using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorController : MonoBehaviour
{
    public UnityEvent onDoorOpen;
    public int keyCount = 0;
    private bool doorOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!doorOpen && keyCount >= 3)
        {
            unlockDoor();
            doorOpen = true;
        }
    }

    private void unlockDoor()
    {
        onDoorOpen.Invoke();
    }

    public void unlockKey()
    {
        keyCount++;
    }
}
