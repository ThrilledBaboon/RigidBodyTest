using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private PlayerControls playerControls;
    private Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        playerControls = new PlayerControls();
        rigidBody = GetComponent<Rigidbody>();
    }

    private void onJump()
    {
        Debug.Log("jump");
    }
}
