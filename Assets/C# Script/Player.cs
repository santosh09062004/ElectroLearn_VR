using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform vrplayer;
    public float speed= 1.5f;
    public bool moveForward;
    private CharacterController cc;
    

    void Start()
    {
        cc= GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount > 0)
        {
            moveForward = true;

        }
        else{
            moveForward = false;
        }
        if (moveForward==true){
            Vector3 forward = vrplayer.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward*speed);

        }
        
    }
}
