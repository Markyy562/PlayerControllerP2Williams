using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnComingCars : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { }
    
        public float speed = 5.0f;
        public float turnSpeed;
    public float horizontalInput;
    // Start is called before the first frame update
    

    public float forwardInput;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}

    



