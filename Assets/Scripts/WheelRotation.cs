using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{

    private float rotationSpeed;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = 40f;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * rotationSpeed, Space.World);
    }
}
