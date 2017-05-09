using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCameraScript : MonoBehaviour
{

    [SerializeField] Transform target;
    const int speed = 5;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, Time.deltaTime * speed, Space.World);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -Time.deltaTime * speed, Space.World);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Time.deltaTime * speed, 0, 0, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Time.deltaTime * speed, 0, 0, Space.World);
        }

        transform.LookAt(target.position);
    }
}