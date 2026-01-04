using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InductionMOTOR : MonoBehaviour
{
    public AudioSource aud;              // Reference to the AudioSource for sound effects
    public Animator anim;  
    
    public AudioSource intro;   
    
    //public List<GameObject> objects = new List<GameObject>();

    public GameObject a;  
    public GameObject b;  
    public GameObject c;  
    public GameObject d;  
    public GameObject e;           // Reference to the Animator component

    public GameObject f;  
    public GameObject g;  
    public GameObject h;  
    public GameObject i;  

    public GameObject j;  
    public GameObject k; 
    public GameObject l; 
    public GameObject m;  
    public GameObject n;  
    
    void Start()
    {
        // Disable the animator initially so the animation doesn't play automatically
        anim.enabled = false;
    }

    public void TiltInteract()
    {
        
        anim.enabled = true;
        play_sound();
        //for (int i = 0; i < objects.Count; i++)
        //{objects[i].SetActive}
        //foreach (GameObject obj in objects)
        //{obj.SetActive(false);}
        a.SetActive(true);
        b.SetActive(true);

        c.SetActive(true);
        d.SetActive(true);
        e.SetActive(true);
        f.SetActive(true);
        g.SetActive(true);
        h.SetActive(true);
        i.SetActive(true);
        j.SetActive(true);
        k.SetActive(true);
        l.SetActive(true);
        m.SetActive(true);
        n.SetActive(true);
       
    }

   

        
    

    public void play_sound()
    {
        aud.Play();
        intro.Play();
    }
}
