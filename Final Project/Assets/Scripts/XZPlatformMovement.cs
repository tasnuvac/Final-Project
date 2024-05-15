using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformXZ : MonoBehaviour
{
    public Vector3[] positions;   

    // Speed of platform's movement
    public float speed = 1.0f;    

    // Current index in the positions array
    private int currentIndex = 0; 

    void Start()
    {
        if (positions.Length > 0)
        {
            // Start at the first position
            transform.position = positions[0];  
        }
    }

    void Update()
    {
        // Return if no positions are set

        if (positions.Length == 0) return;  

        // Move the platform towards the current target position
        transform.position = Vector3.MoveTowards(transform.position, positions[currentIndex], speed * Time.deltaTime);

        // Check if the platform has reached the current target position
        if (Vector3.Distance(transform.position, positions[currentIndex]) < 0.01f)
        {
            // Move to the next position, loop back to the start
            currentIndex = (currentIndex + 1) % positions.Length; 
    }
}
}