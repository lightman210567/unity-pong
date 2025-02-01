using System;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
//using UnityEngine.InputSystem;

public class PaddleMovement : MonoBehaviour
{
    // Initialise properties/variables
    public int player;
    InputAction upAction;
    InputAction downAction;
    public float moveSpeed;
    public Rigidbody2D rigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (player == 1)
        {
            Console.WriteLine("1");
            upAction = InputSystem.actions.FindAction("Up1");
            downAction = InputSystem.actions.FindAction("Down1");
        }
        else
        {
            Console.WriteLine("2");
            upAction = InputSystem.actions.FindAction("Up2");
            downAction = InputSystem.actions.FindAction("Down2");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (upAction.IsPressed())
        {
            rigidBody.linearVelocityY = moveSpeed;
        }
        if (downAction.IsPressed())
        {
            rigidBody.linearVelocityY = -moveSpeed;
        }
        if (upAction.WasReleasedThisFrame() || downAction.WasReleasedThisFrame())
        {
            rigidBody.linearVelocityY = 0;
        }
    }
}
