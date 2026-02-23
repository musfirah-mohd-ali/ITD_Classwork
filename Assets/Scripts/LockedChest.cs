using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LockedChest : MonoBehaviour
{
    [Header("Chest Setup")]
    public XRGrabInteractable treasure;    // Drag your chest's hidden treasure object here
    public XRSocketInteractor lockSocket; // Drag your 'LockSocket' object here

    private void Start()
    {
        // Disable the treasure at the start so it can't be grabbed
        if (treasure != null)
        {
            treasure.enabled = false;
        }
    }

    private void Update()
    {
        // If the socket has an object (the key), enable the treasure
        if (lockSocket != null && lockSocket.hasSelection)
        {
            treasure.enabled = true;
        }
        else
        {
            // Optional: Re-lock if the key is removed
            treasure.enabled = false;
        }
    }
}