using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    public float jumpHeight;
    float hInput;
    float fInput;
    float jInput;
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
        jInput = Input.GetAxis("Jump");
        transform.Translate(Vector3.up * Time.deltaTime * jumpHeight * jInput);
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * fInput);
        //transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        //transform.Translate(Vector3.left * Time.deltaTime * turnSpeed);
        transform.Rotate(Vector3.up * Time.deltaTime * moveSpeed * hInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * hInput);
        
    }
}
