﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCamera : MonoBehaviour
{
    float speed = 50.0f;
    float dropspeed = 100f;
    Camera cam;
    public Transform target;
    public GameObject floor;
    //public GameObject particles;



    void Start()
    {
        cam = GetComponent<Camera>();

    }


    void Update()
    {

        //Trigger event when camera looks at target trigger
        Vector3 screenPoint = cam.WorldToViewportPoint(target.position);
        bool onScreen = screenPoint.z > 0 && screenPoint.x > 0 &&
                        screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1;

        if (onScreen)
        {
            //print("target in view");
            //particles.transform.localScale += new Vector3(0, 0, 100f);
            //floor.AddForce(Vector3.down * 50);
            //floor.transform.Translate(-1* dropspeed * Vector3.forward * Time.deltaTime, Space.World);
            floor.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            GameObject[] FallingChairs = GameObject.FindGameObjectsWithTag("Falling Chair");
            foreach (GameObject obj in FallingChairs)
                obj.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

        }
        //else print("target not in view");

        //WASD keyboard controls for camera
        var v3 = new Vector3 (Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"), 0.0f);
        transform.Rotate(v3 * speed * Time.deltaTime);
    }
}
