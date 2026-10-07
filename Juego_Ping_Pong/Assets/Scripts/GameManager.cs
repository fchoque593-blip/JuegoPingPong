using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ball;

    public GameObject player1;
    public GameObject player1Goal;

    public GameObject player2;
    public GameObject player2Goal;

    public Text player1Text;
    public Text player2Text;

    private int player1Score = 0;
    private int player2Score = 0;

    private void Start()
    {
        UpdateScore();
    }

    public void Player1Scored()
    {
        player1Score++;
        UpdateScore();
        ResetPosition();
    }

    public void Player2Scored()
    {
        player2Score++;
        UpdateScore();
        ResetPosition();
    }

    private void UpdateScore()
    {
        player1Text.text = player1Score.ToString();
        player2Text.text = player2Score.ToString();
    }

    private void ResetPosition()
    {
        player1.GetComponent<Players>().ResetPlayer();
        player2.GetComponent<Players>().ResetPlayer();
        ball.GetComponent<Ball>().ResetBall();
    }
}