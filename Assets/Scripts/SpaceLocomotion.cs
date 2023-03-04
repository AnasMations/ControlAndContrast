using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceLocomotion : MonoBehaviour
{
    public bool isGrapping = false;
    public Transform rightHand;
    Vector3 lastRightHandPosition;

    void Start()
    {
        lastRightHandPosition = rightHand.position;
    }

    void FixedUpdate()
    {
        if(rightHand.position == Vector3.zero)
        {
            isGrapping = false;
            Debug.Log("Right hand is not tracked");
        }
        else
        {
            isGrapping = true;
            Debug.Log("Right hand is tracked");
        }

        if(isGrapping)
        {
            Vector3 movementVector = rightHand.position - lastRightHandPosition;
            transform.position += movementVector;
            lastRightHandPosition = rightHand.position;
            
            //GetComponent<Rigidbody>().velocity = movementVector/Time.deltaTime;
        }

    }
}
