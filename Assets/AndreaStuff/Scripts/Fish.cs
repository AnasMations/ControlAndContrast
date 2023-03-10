using UnityEngine;

public class Fish : MonoBehaviour
{
    public Transform followTarget; // the object the fish will follow
    public float speed = 5f; // the speed at which the fish will follow
    public float acceleration = 2f; // the acceleration of the fish
    public float distance = 0.2f;

    private Vector3 velocity; // the velocity of the fish

    void Update()
    {
        // calculate the direction to the follow target
        Vector3 direction = followTarget.position - transform.position;

        if(direction.magnitude > distance)
        {
            // calculate the desired velocity based on speed and direction
            Vector3 desiredVelocity = direction.normalized * speed;

            // calculate the change in velocity based on acceleration
            Vector3 deltaVelocity = Vector3.ClampMagnitude(desiredVelocity - velocity, acceleration * Time.deltaTime);

            // update the velocity
            velocity += deltaVelocity;

            // move the fish based on the velocity
            transform.position += velocity * Time.deltaTime;

            // rotate the fish to face the follow target
            if (velocity.magnitude > 0.1f)
            {
                transform.rotation = Quaternion.LookRotation(velocity , transform.up);
            }
        }

    }
}
    