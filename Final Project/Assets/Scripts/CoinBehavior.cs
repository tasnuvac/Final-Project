using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{

    // sets rotation speed
    public int RotationSpeed = 100;
    private Transform coinTransform;
    // Start is called before the first frame update
    void Start()
    {
        coinTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        coinTransform.Rotate(RotationSpeed * Time.deltaTime, 0, 0);
    }
}
