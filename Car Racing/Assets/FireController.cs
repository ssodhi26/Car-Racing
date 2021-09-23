using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireController : MonoBehaviour {
    public ParticleSystem LineUp;
    public ParticleSystem Smoke;
    //public ParticleSystem PointLight;
    public ParticleSystem Flash;
   // public AudioSource Audio;
	// Use this for initialization
	void Start ()
    {
       
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            LineUp.Emit(500000);
            Smoke.Emit(500000);
            Flash.Emit(500000);
            //Audio.Play();
        }
    }

    
}
