using UnityEngine;

public class InteractableScaleObject : MonoBehaviour
{
    [Header("Scale Range")]
    public float minScale = 0.1f;
    public float maxScale = 5f;

    public void SetScaleFromSlider(float value)
    {
        float scale = Mathf.Lerp(minScale, maxScale, value);
        transform.localScale = Vector3.one * scale;
    }
}
