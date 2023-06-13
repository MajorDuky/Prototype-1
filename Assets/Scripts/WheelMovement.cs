using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelMovement : MonoBehaviour
{

    private float speed;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        speed = 150f;
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right, speed * Time.deltaTime * verticalInput, Space.Self);
    }
}
