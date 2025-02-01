using System;
using UnityEngine;
using UnityEngine.InputSystem;
//using UnityEngine.InputSystem;

public class PaddleMovement : MonoBehaviour
{
    // Initialise properties/variables
    public int player;
    InputAction upAction;
    InputAction downAction;

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
        Console.Write("Frame");
        if (upAction.IsPressed())
        {
            throw new NotImplementedException();
        }
        if (downAction.IsPressed())
        {
            throw new NotImplementedException();
        }
    }
}
