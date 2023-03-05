using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
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
        key.GetComponent<Key>().unlockFunction();
        key.transform.position = transform.position;
        key.transform.rotation = transform.rotation;
        key.transform.SetParent(transform);
        doorController.unlockKey();
        unlocked = true;
    }
}
