using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameManager gameManager;

    // Activar si esta portería pertenece al jugador 1.
    public bool player1Goal;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Ball>() == null)
        {
            return;
        }

        if (player1Goal)
        {
            gameManager.Player2Scored();
        }
        else
        {
            gameManager.Player1Scored();
        }
    }
}