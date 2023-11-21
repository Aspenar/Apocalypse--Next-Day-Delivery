using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public AudioClip BadDoor;
    public AudioClip GoodDoor;
    public int _score;
    public GameObject GameManager;
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
        GameManager = GameObject.Find("GameManager");
        if (other.tag == "BadBox")
        {
            GetComponent<AudioSource>().PlayOneShot(BadDoor, 0.7F);
            Destroy(other.gameObject);
            GameManager.gameObject.GetComponent<GameManager>()._score += -200;
            print("OH GOD!");
        }
        else if (other.tag == "GoodBox")
        {
            GetComponent<AudioSource>().pitch = (Random.Range(0.95f, 1.05f));
            GetComponent<AudioSource>().PlayOneShot(GoodDoor, 0.7F);
            Destroy(other.gameObject);
            GameManager.gameObject.GetComponent<GameManager>()._score += 100;
            print("Nice!");
        }
    }
}
