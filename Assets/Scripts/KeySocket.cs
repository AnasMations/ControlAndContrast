using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySocket : MonoBehaviour
{
    public bool unlocked = false;
    private DoorController doorController;

    void Start()
    {
        doorController = FindObjectOfType<DoorController>();
        unlocked = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!unlocked && other.gameObject.tag == "key")
        {
            unlock(other.gameObject);
        }
    }

    private void unlock(GameObject key)
    {
        key.transform.position = transform.position;
        key.transform.SetParent(transform);
        key.GetComponent<BoxCollider>().enabled = false;
        unlocked = true;
    }
}
