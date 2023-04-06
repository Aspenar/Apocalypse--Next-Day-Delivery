using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCollision : MonoBehaviour
{
    public float Score = 0;
    public AudioClip BadDoor;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = BadDoor;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Door")
        {
            GetComponent<AudioSource>().Play();
            Destroy(gameObject, 1);
            Score -= 200;
            print("OH GOD!");

        }
    }
}
