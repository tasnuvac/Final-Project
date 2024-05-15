using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeLevel : MonoBehaviour
{
    int buildIndex;
    // Start is called before the first frame update
    void Start()
    {
        buildIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("build index" + buildIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider myCollision)
    {
        SceneManager.LoadScene(buildIndex + 1);
    }
}
