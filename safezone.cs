using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public float shrinkSpeed = 0.5f;

    void Update()
    {
        // Shrink the zone gradually over time
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        if (transform.localScale.x < 1f) // Minimum size
        {
            transform.localScale = Vector3.one;
        }
    }
}