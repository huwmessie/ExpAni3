using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperStack : MonoBehaviour
{
    public Rigidbody paperPrefab;
    public Transform tableTop;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("new paper");
            Rigidbody paperInstance;
            paperInstance = Instantiate(paperPrefab, tableTop.position, tableTop.rotation) as Rigidbody;
            //paperInstance.AddForce(tableTop.up * 5);

        }
    }
}

