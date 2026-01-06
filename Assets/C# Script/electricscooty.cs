using System.Collections;
using UnityEngine;

public class electricscooty : MonoBehaviour
{
    public AudioSource aud;              // Reference to the AudioSource for sound effects
    public Animator anim;  
    
    public AudioSource intro;   
    
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
