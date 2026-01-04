using UnityEngine;

public class lightswitch : MonoBehaviour
{
    public GameObject targetObject; // The GameObject you want to activate

    public AudioSource au;

    // Call this method to activate the GameObject
    public void TiltInteract()
    {
        
        au.Play();
        targetObject.SetActive(true); // Activates the GameObject
        
    }
}