using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{
    CharacterController char_controller;
    PlayerControls playerControls;
    public Transform cam;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        char_controller = GetComponent<CharacterController>();
        playerControls = new PlayerControls();
        playerControls.Player.Enable();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector2 inputVector = playerControls.Player.Move.ReadValue<Vector2>();
        Vector3 inputVector3 = new Vector3(inputVector.x, gameObject.transform.position.y, inputVector.y);
        Vector3 angle_cam = new Vector3(cam.forward.x, 0, cam.forward.z);
        //Vector2 camup = cam.up;
        Vector3 cam_orient = inputVector3.x * cam.right + inputVector3.z * angle_cam;
        cam_orient = cam_orient.normalized;
        if (inputVector.magnitude != 0)
        {
            rb.velocity = cam_orient * 15f;
            transform.rotation = Quaternion.LookRotation(cam_orient);
        }
        else
        {
            //rb.velocity = new Vector3(0, rb.velocity.y, 0);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }

}
