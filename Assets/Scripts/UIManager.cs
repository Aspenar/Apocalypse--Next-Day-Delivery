using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _scoreText;
    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = "Score: " + 0;
        GameObject.FindGameObjectWithTag("Door").GetComponent<CollisionDetector>();
    }

    // Update is called once per frame
    public void updateScore(int _score)
    {
        _scoreText.text = "Score: " + _score.ToString(); 
    }
}
