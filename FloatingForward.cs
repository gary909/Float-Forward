using UnityEngine;

public class FloatForward : MonoBehaviour
{
    // Adjust these values to change the behavior
    public float amplitude = 1.0f; // The height of the float
    public float frequency = 1.0f; // The speed of the float
    public float verticalOffset = 0.0f; // Vertical offset from the initial position
    public float horizontalAmplitude = 1.0f; // The width of the horizontal movement
    public float horizontalFrequency = 1.0f; // The speed of the horizontal movement

    private Vector3 startPos;

    void Start()
    {
        // Store the starting position
        startPos = transform.position;
    }

    void Update()
    {
        // Calculate the new vertical position using a sine wave
        float newY = startPos.y + Mathf.Sin(Time.time * frequency) * amplitude + verticalOffset;

        // Calculate the new horizontal position using a sine wave
        float newX = startPos.x + Mathf.Sin(Time.time * horizontalFrequency) * horizontalAmplitude;

        // Update the enemy's position
        transform.position = new Vector3(newX, newY, transform.position.z);
    }
}
