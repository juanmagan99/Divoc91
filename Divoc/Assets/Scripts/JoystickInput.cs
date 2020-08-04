using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickInput : MonoBehaviour
{
    // USANDO JOYSTICK PACK DE LA ASSET STORE

    [SerializeField]
    private Joystick leftJoystick;
    [SerializeField]
    private Joystick rightJoystick;
    [SerializeField]
    private Transform objectToMove;

    private Rigidbody2D rb2D;


    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb2D.velocity = leftJoystick.Direction * 6;
        if(rightJoystick.Direction.magnitude != 0f)
        {
            objectToMove.transform.right = rightJoystick.Direction;
        }
        else if(leftJoystick.Direction.magnitude != 0f)
        {
            objectToMove.transform.right = leftJoystick.Direction;
        }
    }
}
