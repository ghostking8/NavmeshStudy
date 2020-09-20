using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float speed = 0.1f;

    private bool direction = true;
    private float position_z_start;
     public float position_z_max = 10f;

    // Start is called before the first frame update
    void Start()
    {
        position_z_start = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == true)
        {
            transform.position += new Vector3(0, 0, speed);


            if (transform.position.z >= (position_z_start + position_z_max))
            {
                direction = false;
            }
        }
        else
        {
            transform.position -= new Vector3(0, 0, speed);

            if (transform.position.z <= position_z_start)
            {
                direction = true;
            }
        }        
    }
}
