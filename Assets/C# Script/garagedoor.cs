using System.Collections;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public AudioSource aud;              // Reference to the AudioSource for sound effects
    public Animator anim;                // Reference to the Animator component
    public float stopDelay = 3.0f;       // Time in seconds to wait before stopping the animation

    // Final position and rotation values
    public Vector3 finalPosition = new Vector3(-15.021f, 2.42f, 2.57f);
    public Vector3 finalRotation = new Vector3(0f, 90f, -90f);
    public Material InactiveMaterial;

    /// <summary>
    /// The material to use when this object is active (gazed at).
    /// </summary>
    public Material GazedAtMaterial;

    void Start()
    {
        // Disable the animator initially so the animation doesn't play automatically
        anim.enabled = false;
        
    }

    public void TiltInteract()
    {
        // Enable the animator to play the animation
        anim.enabled = true;
        play_sound();

        // Start a coroutine to stop the animation after 2 seconds
        StartCoroutine(DisableAnimatorAfterDelay(stopDelay));
    }

    private IEnumerator DisableAnimatorAfterDelay(float delay)
    {
        // Wait for the specified delay (2 seconds)
        yield return new WaitForSeconds(delay);

        // Disable the animator to stop the animation
        anim.enabled = false;

        // Set the GameObject to the final position and rotation
        transform.localPosition = finalPosition;
        transform.localRotation = Quaternion.Euler(finalRotation);
    }
    
    public void play_sound()
    {
        aud.Play();
    }
}
