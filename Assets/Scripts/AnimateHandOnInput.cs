using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty PinchAnimatinAction;
    public InputActionProperty gripAnimationAction;
    public Animator handAnimator;


    // Update is called once per frame
    void Update()
    {
        //gets trigger input value for hand animation
        float triggerValue = PinchAnimatinAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);

        float gripvalue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripvalue);
    }
}