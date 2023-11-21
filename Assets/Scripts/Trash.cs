using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BadBox")
        {
            Destroy (other.gameObject);
        }
        if (other.gameObject.tag == "GoodBox")
        {
            Destroy(other.gameObject);
        }
    }
}
