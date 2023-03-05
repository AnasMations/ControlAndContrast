using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Key : MonoBehaviour
{
    public UnityEvent onKeyUnlock;

    public void unlockFunction()
    {
        onKeyUnlock.Invoke();
    }
}
