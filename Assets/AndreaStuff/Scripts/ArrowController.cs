using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public GameObject[] keys; // list of keys to point towards
    public GameObject arrow; // the arrow object to rotate

    private int currentKeyIndex = 0;

    void Start()
    {
        PointToCurrentKey();
    }

    void PointToCurrentKey()
    {
        if (keys.Length > 0 && arrow != null)
        {
            Vector3 direction = (keys[currentKeyIndex].transform.position - arrow.transform.position).normalized;
            direction.y = 0; // set y direction to zero to only rotate on Y axis
            arrow.transform.rotation = Quaternion.LookRotation(direction, Vector3.up) * Quaternion.Euler(-90f, 0f, 0f); // apply rotation with -90 degree offset on X axis
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == keys[currentKeyIndex])
        {
            currentKeyIndex++;
            if (currentKeyIndex >= keys.Length)
            {
                currentKeyIndex = 0;
            }
            PointToCurrentKey();
        }
    }

    public void NextKey()
    {
        currentKeyIndex++;
        if (currentKeyIndex >= keys.Length)
        {
            currentKeyIndex = 0;
        }
        PointToCurrentKey();
    }

    void Update()
    {
        PointToCurrentKey();
    }
}
