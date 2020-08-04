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

    private void Update()
    {
        objectToMove.Translate(leftJoystick.Direction, Space.World);
        if(rightJoystick.Direction.magnitude != 0f)
        {
            objectToMove.transform.up = rightJoystick.Direction;
        }
        else
        {
            objectToMove.transform.up = leftJoystick.Direction;
        }
    }
}
