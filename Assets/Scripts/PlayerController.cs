using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    // Private Variables
    public float speed = 5.0f;
    public float turnSpeed = 25.0f;
    public float horizontalMove;
    public float verticalMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Left and right direction from InputManager
        horizontalMove = Input.GetAxis("Horizontal");
        // Forward and Backword Direction
        verticalMove = Input.GetAxis("Vertical");
        // We are gonna move the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalMove);
        // move the car to right and left
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalMove);
    }
}
