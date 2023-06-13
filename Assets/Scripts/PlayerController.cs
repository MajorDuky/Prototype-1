using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horsePower;
    [SerializeField] private float turnSpeed;
    [SerializeField] GameObject centerOfMass;
    [SerializeField] TMP_Text speedMeter;
    [SerializeField] TMP_Text rpmText;
    [SerializeField] List<WheelCollider> allWheels;
    private Rigidbody rb;
    private float speed;
    private float rpm;
    private float horizontalInput;
    private float verticalInput;
    private bool isOnGround;
    // Start is called before the first frame update
    void Start()
    {
        turnSpeed = 40f;
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = centerOfMass.transform.localPosition;
        isOnGround = true;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (allWheels.Count != 0)
        {
            int wheelsOnGround = 0;
            foreach (var wheel in allWheels)
            {
                if (wheel.isGrounded)
                {
                    wheelsOnGround++;
                }
            }

            isOnGround = wheelsOnGround == 4 ? true : false;
        }

        if (isOnGround)
        {
            // Moves the vehicle forward / backward
            rb.AddRelativeForce(verticalInput * horsePower * Vector3.forward);

            // If verticle input != 0, then the vehicle is moving forward or backward and will be able to stirr
            if (verticalInput != 0)
            {
                // Rotates the vehicle right or left
                transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
            }
        }

        speed = Mathf.Round(rb.velocity.magnitude * 3.6f);
        speedMeter.SetText($"Speed : {speed} km/h");
        rpm = Mathf.Round((speed % 30) * 40);
        rpmText.SetText($"RPM : {rpm}");
    }
}
