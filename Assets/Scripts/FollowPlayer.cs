using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    private float cameraInput;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 5, -10);
        timer = 0;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        cameraInput = Input.GetAxis("Fire1");
        if(cameraInput == 0 && offset.x == -0.4f && offset.y == 2 && offset.z == 0.1f)
        {
            transform.rotation = player.transform.rotation;
        }
        if(cameraInput !=0 && offset.x == 0 && offset.y == 5 && offset.z == -10 && timer == 0)
        {
            timer = 360;
            offset = new Vector3(-0.4f, 2, 0.1f);
            transform.Rotate(Vector3.right, -10);
        } 
        else if (cameraInput !=0 && offset.x == -0.4f && offset.y == 2 && offset.z == 0.1f && timer == 0)
        {
            timer = 360;
            offset = new Vector3(0, 5, -10);
            transform.Rotate(Vector3.right, 10);
        }
        else
        {
            if(timer > 0) {
                timer -= 1;
            }
        }
        transform.position = player.transform.position + offset;
    }
}
