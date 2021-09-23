using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour {
    public Text Score;
    public Text complete;
    public Text Life;
    public AudioSource Audio;
    private Rigidbody rb;
    private int life;
    int count;
    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        life = 50;
        Score.text = "Coins Collected : " + count.ToString();
        Life.text = "Life : " + life.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        
       
        if (other.gameObject.CompareTag("Hit"))
        {
            Audio.Play();
            other.gameObject.SetActive(false);
            count++;
            Score.text = "Coins Collected : " + count.ToString();
            //Destroy(gameObject);
            //animation.Play("fall");
        }
        if( other.gameObject.CompareTag("Fire"))
        {
            life--;
            Life.text = "Life : " + life.ToString();
           if(life<=0)
            {
                Time.timeScale = 0;
                complete.text = "Game Over!";
            } 
        }
        if(other.gameObject.tag=="finish")
        {
            Time.timeScale = 0;
            complete.text = "Level Complete!";
        }
        
    }
}
