using System.Collections;
using UnityEngine;

public class DCMOTOR : MonoBehaviour
{
    public AudioSource aud;  
    public AudioSource intro;            
    public Animator anim;                
    
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    public GameObject f;
    public GameObject g;
    public GameObject h;
    void Start()
    {
        
        anim.enabled = false;
    }

    public void TiltInteract()
    {
        // Enable the animator to play the animation
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


        // Start a coroutine to stop the animation after 2 seconds
        
    }

    

    public void play_sound()
    {
        aud.Play();
        intro.Play();
    }
}
