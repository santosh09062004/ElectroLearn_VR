using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Tiltinteract : MonoBehaviour
{
    public Transform cam;
    

    public Transform othercrosshair;
    bool interact = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = cam.position + cam.forward * 2;
        transform.position = target;
        transform.LookAt(cam.position);
        othercrosshair.position = target;
        othercrosshair.LookAt(cam.position);
        othercrosshair.Rotate(0,0,-45);
        transform.Rotate(0,0,-cam.rotation.eulerAngles.z);

        float angle = Quaternion.Angle(transform.rotation,othercrosshair.rotation);
        
        if (angle < 3 && interact == false){
            
            RaycastHit hit;
            
            if (Physics.Raycast(cam.position, cam.forward, out hit, 10))
            {
                
                hit.transform.gameObject.SendMessage ("TiltInteract");

            }
            interact= true;

        }

        if (angle > 6){
            interact = false;
        }
    }
}
