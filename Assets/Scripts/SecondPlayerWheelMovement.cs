using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerWheelMovement : MonoBehaviour
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
        verticalInput = Input.GetAxis("Vertical_Local");
        transform.Rotate(Vector3.right, speed * Time.deltaTime * verticalInput, Space.Self);
    }
}
