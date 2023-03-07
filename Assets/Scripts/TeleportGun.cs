//jacob lueke 07/03/2023 teleport gun script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


//script and point are enabled and dissabled via interactable pickup script
public class TeleportGun : MonoBehaviour
{

    public Transform playerRig; // player XR Rig 
    public Transform barrelPont; // gun barrel aim direction
    public Transform teleportPoint; // point to telport to
    public float range = 25f; //range of teleport
    private float isBeingHeld;


    void Start()
    {
        //gets grabbable script
        XRGrabInteractable grabbable_cs = GetComponent<XRGrabInteractable>();
        grabbable_cs.activated.AddListener(DoTeleport); //listens for interaction input
    }

    public void DoTeleport(ActivateEventArgs argument) 
    {
        playerRig.position = teleportPoint.position;
    }

    private void FixedUpdate()
    {
        RaycastHit hit; //raycast variable
        if (Physics.Raycast(barrelPont.position, barrelPont.transform.forward, out hit, range))
        {
            teleportPoint.position = hit.point; //sets teleport point to ray hit point
        }
    }


}
