using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesWheel : MonoBehaviour
{

    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 150f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right, speed * Time.deltaTime, Space.Self);
    }
}
