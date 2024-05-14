using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
    private float _vInput;
    private float _hInput;

    public float JumpVelocity = 5f;
    private bool _isJumping;
    public Vector3 startPosition;

    private Rigidbody _rb;
 
    void Start()
    {

        _rb = GetComponent<Rigidbody>();
        // storing start position
        startPosition = transform.position;

     }
    void Update()
    {
        // rotation of player
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;

        // jumping
        _isJumping |= Input.GetKeyDown(KeyCode.Space);
        /*
        this.transform.Translate(Vector3.forward * _vInput *
        Time.deltaTime);
        this.transform.Rotate(Vector3.up * _hInput * Time.deltaTime);
        */
     }
    void FixedUpdate()
    {
        // roation of player
        Vector3 rotation = Vector3.up * _hInput;

        Quaternion angleRot = Quaternion.Euler(rotation *
        Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position +
        this.transform.forward * _vInput * Time.fixedDeltaTime);

        _rb.MoveRotation(_rb.rotation * angleRot);

        // jumping
        if(_isJumping)
        _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
        _isJumping = false;
    }

    public void ResetToStartPosition()
    {
        // Resets the player position to the start
        transform.position = startPosition;  
    }
} 
