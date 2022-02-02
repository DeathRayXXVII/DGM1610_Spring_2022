using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    public float jumpHeight;
    float hInput;
    float fInput;
    float jInput;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
       // jInput = Input.GetAxis("Jump");
        transform.Translate(Vector3.up * Time.deltaTime * jumpHeight * jInput);
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * fInput);
        //transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        //transform.Translate(Vector3.left * Time.deltaTime * turnSpeed);
        //transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * hInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * hInput);
        
    }
}
