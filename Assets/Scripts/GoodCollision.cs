using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodCollision : MonoBehaviour
{
    public float Score = 0;
    public AudioClip goodDoor;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = goodDoor;
    }

    // Update is called once per frame
    void OnCollisionEnter (Collision col) { 
        if (col.gameObject.tag == "Door")
        {
            GetComponent<AudioSource>().Play();
            Destroy(gameObject, 1);
            Score += 100;
            print ("Nice!");
            
        }
    }
}
