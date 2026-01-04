using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioscript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource aud;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play_sound(){
        aud.Play();
    }
}
