using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndLevelTextDisplay : MonoBehaviour
{
    public GameObject backgroundImage; // Reference to the UI Background Image
    public Text finishText; // Reference to the UI Text element

    void Start()
    {
        // Background image and text are not visible initially
        if (backgroundImage != null)
        {
            backgroundImage.SetActive(false);
        }
        if (finishText != null)
        {
            finishText.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Display the finish message and background image
            if (backgroundImage != null)
            {
                backgroundImage.SetActive(true);
            }
            if (finishText != null)
            {
                finishText.gameObject.SetActive(true);
                finishText.text = "You Won!";
            }
        }
    }
}