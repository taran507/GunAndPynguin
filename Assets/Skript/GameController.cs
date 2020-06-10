using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    private int score;
    private void Start()
    {
        score = 0;
        UpdateScore();
    }
    void UpdateScore()
    {
        scoreText.text = "Record: " + score;
    }
    public void AddScore()
    {
        score ++;
        UpdateScore();
    }
}
