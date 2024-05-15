using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reverse : MonoBehaviour
{
    public float height = 5.0f;   // Height above the initial position to start from
    public float speed = 1.0f;    // Speed of platform's movement
    public float stopYPosition = 0.0f; // The y position where the platform should stop moving
    private float startYPosition;
    private bool movingDown = true; // Flag to control the direction of movement

    void Start()
    {
        startYPosition = transform.position.y + height; // Calculate start position
        transform.position = new Vector3(transform.position.x, startYPosition, transform.position.z); // Set the initial position
    }

    void Update()
    {
        // Determine the target position based on the direction of movement
        float targetYPosition = movingDown ? stopYPosition : startYPosition;

        // Move the platform towards the target position
        float newY = Mathf.MoveTowards(transform.position.y, targetYPosition, speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        // Check if the platform has reached the target position
        if (Mathf.Approximately(transform.position.y, targetYPosition))
        {
            movingDown = !movingDown; // Toggle the direction
        }
    }
}