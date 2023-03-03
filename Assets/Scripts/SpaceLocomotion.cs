using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceLocomotion : MonoBehaviour
{
    public Transform rightHand;
    Vector3 lastRightHandPosition;

    void Update()
    {
        Vector3 movementVector = rightHand.position - lastRightHandPosition;
        transform.position += movementVector;
        lastRightHandPosition = rightHand.position;

        GetComponent<Rigidbody>().velocity = movementVector/Time.deltaTime;
    }
}
