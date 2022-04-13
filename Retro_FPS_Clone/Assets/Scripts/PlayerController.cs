using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    
    private Rigidbody rb;
    private Vector3 moveInput;
    private Vector2 mouseInput;
    public float mouseSensitivity = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Finding the Rigidbody
        Cursor.visible = false; //Having the cursor invisibale
        Cursor.lockState = CursorLockMode.Locked; //locks the cursor
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); //Getting inputs
        Vector3 moveH = transform.right * moveInput.x; //Used to help blend movement
        Vector3 moveV = transform.forward * moveInput.z; //Used to help blend movemnt
        rb.velocity = (moveH + moveV) * moveSpeed; //Adding speed to movement

        mouseInput = new Vector2(-Input.GetAxis("Mouse X"), -Input.GetAxis("Mouse Y")) * mouseSensitivity; //Inputting the Mouse Sensitivity
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x + mouseInput.y, transform.rotation.eulerAngles.y - mouseInput.x, transform.rotation.eulerAngles.z); //Uses the mouse to lock around in a 360 rotation
    }
}
