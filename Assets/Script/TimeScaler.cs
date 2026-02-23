using UnityEngine;

public class TimeScaler : MonoBehaviour
{
    public Transform playerRoot;
    public float exponent = 0.5f; // tweak for feel

    void Update()
    {
        float scale = playerRoot.localScale.x;

        Time.timeScale = Mathf.Pow(scale, exponent);
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }
}
