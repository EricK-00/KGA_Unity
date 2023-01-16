using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeObj : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private bool isJumped;

    private void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isJumped && Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.AddForce(0, 300, 0, ForceMode.Acceleration);
            //isJumped = true;
        }

        if (Input.GetKey(KeyCode.W))
        {
            myRigidbody.AddForce(0, 0, 10);
        }
        if (Input.GetKey(KeyCode.S))
        {
            myRigidbody.AddForce(0, 0, -10);
        }
        if (Input.GetKey(KeyCode.A))
        {
            myRigidbody.AddForce(-10, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            myRigidbody.AddForce(10, 0, 0);
        }
    }
}