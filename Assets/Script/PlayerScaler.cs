using UnityEngine;

public class PlayerScaler : MonoBehaviour
{
    [Header("Player Root (Parent of XR Rig)")]
    public Transform playerRoot;

    [Header("Scaling Settings")]
    public float scaleSpeed = 3f;  
    public float targetScale = 1f; 

    void Update()
    {
        float current = playerRoot.localScale.x;
        float newScale = Mathf.Lerp(current, targetScale, Time.deltaTime * scaleSpeed);
        playerRoot.localScale = Vector3.one * newScale;
    }

    public void SetScale(float scale)
    {
        targetScale = Mathf.Clamp(scale, 0.001f, 1000f); // 1:1000 range
    }
}
