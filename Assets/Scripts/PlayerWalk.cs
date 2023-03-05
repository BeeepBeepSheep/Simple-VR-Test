// jacob lueke, 27/02/2023,simple move sript
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWalk : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 moveDirection;
    private Vector2 inputDirection;
    public Transform orientation;
    public Transform head; // camera

    private void FixedUpdate()
    {
        MovePlayer();
    }
    private void Update()
    {
        UpdateOrientation();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        inputDirection = context.ReadValue<Vector2>(); // get input
    }

    public void MovePlayer()
    {
        moveDirection = orientation.forward * inputDirection;
    }

    private void UpdateOrientation()
    {
        orientation.eulerAngles = new Vector3(0, head.rotation.y, 0);
    }
}
