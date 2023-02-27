// jacob lueke, 27/02/2023, simple vr teleport script (/ note the adding script to rig andadding game objects)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; //note / note rename scene / note making game objects for teleport

public class SimpleTeleport : MonoBehaviour // note name
{
    public Transform playerRig; //note variables 
    public Transform handPoint;
    public Transform teleportPoint;
    public float range = 25f;

    public void TeleportToPoint(InputAction.CallbackContext context)//note all
    {
        if (context.performed) //note input type
        {
            playerRig.position = teleportPoint.position; //note
        }
    }

    private void FixedUpdate() //note
    {
        RaycastHit hit; //note
        if (Physics.Raycast(handPoint.position, handPoint.transform.forward, out hit, range))
        {
            teleportPoint.position = hit.point; //note
        }
    }
}
