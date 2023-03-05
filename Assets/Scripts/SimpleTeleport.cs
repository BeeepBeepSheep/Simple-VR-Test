// jacob lueke, 27/02/2023, simple vr teleport script
using UnityEngine;
using UnityEngine.InputSystem; //note / note rename scene / note making game objects for teleport

public class SimpleTeleport : MonoBehaviour
{
    public Transform playerRig; // player XR Rig 
    public Transform handPoint; // right hand aim direction
    public Transform teleportPoint; // point to telport to
    public float range = 25f; //range of teleport


    //Function to be called on player input
    //gets the context of input, e.g. if action performed, cancled or started
    public void TeleportToPoint(InputAction.CallbackContext context)
        
    {
        if (context.performed) // if the input has been performed
        {
            playerRig.position = teleportPoint.position;
            //set player position to telport point position
        }
    }


    //fixed update calls 60 times a second instead of every fram like update
    //not frame rate dependant
    private void FixedUpdate() 
    {
        RaycastHit hit; //raycast variable
        //a raycast is line that detetcs what it touches)

        //create ray from hand
        //handpoint.forward is its possative x axis and the direction the ray shoots
       
        if (Physics.Raycast(handPoint.position, handPoint.transform.forward, out hit, range))
        {
            teleportPoint.position = hit.point; //sets teleport point to ray hit point
        }
    }
}
