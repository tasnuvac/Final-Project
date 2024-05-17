using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionHandler : MonoBehaviour
{
    private PlayerBehavior playerBehavior;

    void Start()
    {
        // Attaching the playerBehavior to a game object (attempting to)
        playerBehavior = GetComponent<PlayerBehavior>();
        if (playerBehavior == null)
        {
            //If it does to attach properly, an error message will appear
            Debug.LogError("PlayerBehavior script not found on " + gameObject.name);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the object the player collided with has the tag "Ground".
        if (collision.gameObject.CompareTag("Ground"))
        {
            // When player collides with ground, they are reset to their starting position
            playerBehavior.ResetToStartPosition();
        }
    }
}