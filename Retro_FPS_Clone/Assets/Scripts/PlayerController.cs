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
        rb = GetComponent<Rigidbody>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.locked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
