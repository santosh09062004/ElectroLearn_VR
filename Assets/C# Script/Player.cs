using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    public Transform vrplayer;   // Assign Main Camera (VR Head)
    public float speed = 1.5f;

    private CharacterController cc;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Android VR input: screen tap / cardboard trigger
        bool moveForward =
            Pointer.current != null &&
            Pointer.current.press.isPressed;

        if (moveForward)
        {
            Vector3 forward = vrplayer.forward;
            forward.y = 0f; // prevent vertical movement
            cc.SimpleMove(forward * speed);
        }
    }
}
