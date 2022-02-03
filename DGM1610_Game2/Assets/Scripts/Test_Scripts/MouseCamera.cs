using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    public Camera camera;
    public float speed;
    public float sensitivity;
    float mouseX;
    float mouseY;
    float moveFB;
    float moveLR;
    //PlayerController controller;
    // Start is called before the first frame update
    void Start()
    {
        //controller.GetComponent<PlayerController>();
         Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        moveFB = Input.GetAxis("Vertical");
        moveLR = Input.GetAxis("Horizontal");
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(0, mouseX * sensitivity, 0);
        // Vector3 movement = new Vector3(moveLR * speed * Time.deltaTime, 0, moveFB * speed * Time.deltaTime);
        //controller.moveSpeed(transform.rotation * movement);
        camera.transform.Rotate(-mouseY * sensitivity, 0, 0);
    }
}
