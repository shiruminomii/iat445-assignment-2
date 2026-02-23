using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrowObject : MonoBehaviour
{
    public PlayerScaler scaler;
    public float growMultiplier = 2.5f;

    private void OnEnable()
    {
        GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>().selectEntered.AddListener(OnPickup);
    }

    private void OnDisable()
    {
        GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>().selectEntered.RemoveListener(OnPickup);
    }

    private void OnPickup(SelectEnterEventArgs args)
    {
        scaler.SetScale(scaler.targetScale * growMultiplier);
    }
}
