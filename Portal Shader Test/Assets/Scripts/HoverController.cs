using UnityEngine;

public class HoverController : MonoBehaviour
{
    // Transforms to act as start and end markers for the journey.
    private Vector3 startMarker;
    private float delay;
    public float amplitude = .25f;
    public float period = 2.5f;
 
    protected void Start() {
        startMarker = gameObject.transform.position;
        delay = Random.Range(0, 15);
    }
 
    protected void Update() {
        float theta = (Time.timeSinceLevelLoad+delay) / period;
        float distance = amplitude * Mathf.Sin(theta);
        transform.position = startMarker + Vector3.up * distance;
    }

    float CalculateRandomHeight() {
        return Random.Range(0, 1f);
    }
}
