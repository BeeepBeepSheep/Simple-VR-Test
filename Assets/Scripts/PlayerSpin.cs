// jacob lueke, 27/02/2023, simple vr rotate player script
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSpin : MonoBehaviour
{
    public float sensitivity = 1.2f;
    public Transform playerRig;
    private Vector2 horizontalInput;
    public GameObject blackScreen;

    private void Awake()
    {
        blackScreen.SetActive(false);
    }
    public void LookInput(InputAction.CallbackContext context)
    {
        horizontalInput = context.ReadValue<Vector2>();
        playerRig.Rotate(0, horizontalInput.x * sensitivity, 0);
    }
}