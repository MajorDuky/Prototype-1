using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerController : MonoBehaviour
{
    private float speed;
    private float turnSpeed;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        speed = 25f;
        turnSpeed = 40f;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal_Local");
        verticalInput = Input.GetAxis("Vertical_Local");
        
        // Moves the vehicle forward / backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // If verticle input != 0, then the vehicle is moving forward or backward and will be able to stirr
        if (verticalInput != 0)
        {
            // Rotates the vehicle right or left
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        }
    }
}
