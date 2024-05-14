using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionHandler : MonoBehaviour
{
    private PlayerBehavior playerBehavior;

    void Start()
    {
        playerBehavior = GetComponent<PlayerBehavior>();
        if (playerBehavior == null)
        {
            Debug.LogError("PlayerBehavior script not found on " + gameObject.name);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            playerBehavior.ResetToStartPosition();
        }
    }
}