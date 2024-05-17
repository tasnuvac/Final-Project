using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeLevel : MonoBehaviour
{
    int buildIndex;

    // Reference to the UI Background Image
    public GameObject backgroundImage; 

    // Reference to the UI Text element
    public Text finishText; 

    // Start is called before the first frame update
    void Start()
    {
        // Get the current build index
        buildIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("build index: " + buildIndex);

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

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider myCollision)
    {
        Debug.Log("Collision detected with: " + myCollision.gameObject.name);

        // Check if this is the last level
        if (IsLastLevel())
        {
            Debug.Log("Player has reached the last level.");

            // Displays the finish message and background image
            if (backgroundImage != null)
            {
                backgroundImage.SetActive(true);
            }
            if (finishText != null)
            {
                finishText.gameObject.SetActive(true);
                finishText.text = "Congrats, you finished the game!";
            }
        }
        else
        {
            // Load the next level
            Debug.Log("Loading next level...");
            SceneManager.LoadScene(buildIndex + 1);
        }
    }

    // Helper method to check if this is the last level
    bool IsLastLevel()
    {
        return buildIndex == SceneManager.sceneCountInBuildSettings - 1;
    }
}