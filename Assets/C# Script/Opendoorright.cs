using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opendoorright : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component

    // Start is called before the first frame update
    public void TiltInteract()
    {
        // Call RotateObject() to start rotation with sound
        RotateObject();
    }

    // Method to handle rotation and play sound
    void RotateObject()
    {
        // Play the sound effect
        audioSource.Play();

        // Start the rotation coroutine
        StartCoroutine(RotateOverTime(2f)); // Rotate over 2 seconds
    }

    // Coroutine to handle smooth rotation
    IEnumerator RotateOverTime(float duration)
    {
        Quaternion startRotation = transform.rotation;
        Quaternion endRotation = Quaternion.Euler(0f, -90f, 0f);
        float timeElapsed = 0f;

        while (timeElapsed < duration)
        {
            transform.rotation = Quaternion.Lerp(startRotation, endRotation, timeElapsed / duration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }

        transform.rotation = endRotation; // Ensure it ends exactly at 90 degrees
    }
}
