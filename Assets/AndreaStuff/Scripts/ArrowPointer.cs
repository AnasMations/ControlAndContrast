using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPointer : MonoBehaviour
{
    public GameObject[] keys;
    public GameObject door;
    public GameObject arrow;

    private int currentKeyIndex = 0;

    void Start()
    {
        UpdateArrowTarget();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == keys[currentKeyIndex])
        {
            currentKeyIndex++;
            UpdateArrowTarget();
        }
    }

    public void SetRemainingKeyTarget()
    {
        for (int i = 0; i < keys.Length; i++)
        {
            if (i != currentKeyIndex)
            {
                arrow.transform.LookAt(keys[i].transform.position);
                break;
            }
        }
    }

    void UpdateArrowTarget()
    {
        if (currentKeyIndex < keys.Length)
        {
            arrow.transform.LookAt(keys[currentKeyIndex].transform.position);
        }
        else
        {
            arrow.transform.LookAt(door.transform.position);
        }
    }
}
