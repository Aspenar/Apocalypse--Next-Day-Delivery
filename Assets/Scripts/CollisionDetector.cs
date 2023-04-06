using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public AudioClip BadDoor;
    public AudioClip GoodDoor;
    public int _score;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponents<AudioSource>();
        //_player = GameObject.Find("Player").GetComponent<Player>();

    }
    public void AddScore(int addPoints)
    {
        _score += addPoints;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BadBox")
        {
            GetComponent<AudioSource>().PlayOneShot(BadDoor, 0.7F);
            Destroy(other.gameObject);
            _score += -200;
            print("OH GOD!");
        }
        else if (other.tag == "GoodBox")
        {
            GetComponent<AudioSource>().PlayOneShot(GoodDoor, 0.7F);
            Destroy(other.gameObject);
            _score += 100;
            print("Nice!");
        }
    }
}
