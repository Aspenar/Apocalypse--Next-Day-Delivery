using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject WinUI;
    [SerializeField] private GameObject LoseUI;
    [SerializeField] private GameObject ScoreUI;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text messageText;
    public int _score;
    private bool gameOver;
    private bool restart;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        WinUI.SetActive(false);
        LoseUI.SetActive(false);
        _score = 0;
        messageText.text = "press X to Spawn boxes, try not to blow anyone up.";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = _score.ToString();
        if (_score > 0)
        {
            messageText.text = "Keep it up!";
        }
        else if (_score < 0)
        {
            messageText.text = "Stop blowing people's houses up";
        }
        if (_score <= -600)
        {
            LoseUI.SetActive(true);
            ScoreUI.SetActive(false);
            gameOver = true;
        }
        if (_score >= 800)
        {
            WinUI.SetActive(true);
            ScoreUI.SetActive(false);
            gameOver = true;
        }
    }
        public void onRestart(InputAction.CallbackContext context)
    {
        restart = context.action.triggered;
        RestartButton();
    }
    public void RestartButton()
    {
        if (gameOver == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
