using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletController : MonoBehaviour
{
    //public Text Enemies;
    //int count;
    public AudioSource Audio;
    // Use this for initialization
    void Start()
    {
       // count = 0;
        //Enemies.text = "Enemies Destroyed:" + count.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Fire"))
        {
            Audio.Play();
            other.gameObject.SetActive(false);
           // count++;
            //Enemies.text = "Enemies Destroyed:" + count.ToString();
        }
    }
    

}
