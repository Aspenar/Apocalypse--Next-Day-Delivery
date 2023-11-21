using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject ScoreUI;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text messageText;
    public int _score;
    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        messageText.text = "press X to Spawn boxes, try not to blow anyone up.";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = _score.ToString();
    }
}
