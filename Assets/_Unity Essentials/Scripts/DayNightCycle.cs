using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // The number of seconds in a full day
    public float dayDuration = 120f; // Default is 2 minutes for a full day

    // Update is called once per frame
    void Update()
    {
        // Calculate the rotation angle per second
        float rotationAngle = 360f / dayDuration * Time.deltaTime;

        // Rotate the light around the x-axis
        transform.Rotate(new Vector3(rotationAngle, 0, 0));
    }
}