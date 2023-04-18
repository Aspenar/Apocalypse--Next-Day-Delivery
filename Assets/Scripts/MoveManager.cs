using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveManager : MonoBehaviour
{
    public float moveTimer= 10.0f;
    public GameObject[] moveTargets;
    public GameObject Player;
    public AudioSource PlayerAudio;
    public AudioClip truckClose;
    //public Vector3 nextMove;
    //public Vector3 currentSpot;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
       
    }
     void reset_moveTimer()
        {
            moveTimer += 10.0f;
        }

    // Update is called once per frame
    void Update()
    {
        if(moveTimer > 0)
        {
            moveTimer -= Time.deltaTime;
        } 
        else if(moveTimer <= 0) {

            var i = Random.Range(0, moveTargets.Length);
            Player.transform.position = moveTargets[i].transform.position;
            Player.transform.rotation = moveTargets[i].transform.rotation;
            PlayerAudio.pitch = (Random.Range(0.95f, 1.05f));
            PlayerAudio.PlayOneShot(truckClose, 0.7f);
            reset_moveTimer();
        }
    }
}
