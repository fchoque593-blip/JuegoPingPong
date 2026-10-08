using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public int puntosParaGanar = 3;

    public AudioSource audioSource;
    public AudioClip sonidoPunto;

    private void Start()
    {
        UpdateScore();
    }

    public void Player1Scored()
    {
        audioSource.PlayOneShot(sonidoPunto);

        player1Score++;

        UpdateScore();

        if (player1Score >= puntosParaGanar)
        {
            TerminarJuego("JUGADOR 1");
            return;
        }

        ResetPosition();
    }

    public void Player2Scored()
    {
        audioSource.PlayOneShot(sonidoPunto);

        player2Score++;

        UpdateScore();


        if (player2Score >= puntosParaGanar)
        {
            TerminarJuego("JUGADOR 2");
            return;
        }

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

    private void TerminarJuego(string ganador)
    {
        PlayerPrefs.SetString("Ganador", ganador);
        PlayerPrefs.Save();

        SceneManager.LoadScene("MenuPrincipal");
    }

    public void VolverAlMenu()
    {
        PlayerPrefs.DeleteKey("Ganador");

        SceneManager.LoadScene("MenuPrincipal");
    }
}