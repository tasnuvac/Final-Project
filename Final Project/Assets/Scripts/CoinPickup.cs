using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ItemBehavior : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {

            // Once the item is collected, it gets "destroyed" so the player knows they picked it up
            Destroy(this.transform.gameObject);
            Debug.Log("Item collected!");
        }
    }
} 