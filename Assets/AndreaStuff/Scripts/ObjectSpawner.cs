using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectList;
    public int numObjects;
    public float sphereRadius;
    public float objectScale;
    public float maxVelocity;
    public float minVelocity;

    void Start()
    {
        for (int i = 0; i < numObjects; i++)
        {
            GameObject newObj = Instantiate(objectList[Random.Range(0, objectList.Length)], Random.insideUnitSphere * sphereRadius + transform.position, Quaternion.identity);
            
            newObj.transform.localScale *= Random.Range(0.5f, 1.5f) * objectScale;
            newObj.transform.parent = transform;

            Rigidbody rb = newObj.AddComponent<Rigidbody>();
            rb.useGravity = false;
            rb.velocity = Random.insideUnitSphere * Random.Range(minVelocity, maxVelocity);
            rb.angularVelocity = Vector3.zero;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sphereRadius);
    }
}
