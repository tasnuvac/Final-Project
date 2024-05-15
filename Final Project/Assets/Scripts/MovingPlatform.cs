using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float height = 5.0f;   // Maximum height the platform 
    public float speed = 1.0f;     // Speed of platform
    public float stopYPosition = 5.0f; // The y position where the platform should stop moving
    private float originalY;

    void Start()
    {
        originalY = transform.position.y;
        stopYPosition = originalY + height; // Calculate stop position based on original height and added height
    }

    void Update()
    {
        // Calculate the next y position
        float newY = Mathf.Abs(Mathf.Sin(Time.time * speed)) * height + originalY;

        // to not exceed stopYPosition
        newY = Mathf.Min(newY, stopYPosition);

        // Move the platform to the new y position
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}

