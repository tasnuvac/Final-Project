using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reverse : MonoBehaviour
{
    // Height above the initial position to start from
    public float height = 5.0f;  

    // Speed of platform's movement
    public float speed = 1.0f;    

    // The y position where the platform should stop moving
    public float stopYPosition = 0.0f; 
    private float startYPosition;

    // To control the direction of movement
    private bool movingDown = true; 

    void Start()
    {
        // Calculate start position
        startYPosition = transform.position.y + height; 
        
        // Set the initial position
        transform.position = new Vector3(transform.position.x, startYPosition, transform.position.z); 
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
            // Toggle the direction
            movingDown = !movingDown; // Toggle the direction
        }
    }
}

/*
I got some help from my friend with this one. He has been doing cs since he was in highschool and used Csharp to make small games like these before.
I was struggling to figure out how to get the platform to move up and down using the book. I also looked online a bit and figured out how to get it to start from a 
position and come back down only along the y plane. He helped me figure out how to tweak the code a bit to make sure it loops since when I was doing it, I was struggling
to make it loop. By recieving that help from him and the internet, I was able to use some of this information that I learned with the platform that moves along the x plane.
I was able to code that myself and have him look over it and he said everything seemed to work fine. It helped me grow a coder and now I know how to code an object
that moves horizontally and vertically. 
*/