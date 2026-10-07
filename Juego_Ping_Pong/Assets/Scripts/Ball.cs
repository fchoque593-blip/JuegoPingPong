using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 7f;
    public Rigidbody2D rb;

    private Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
        Launch();
    }

    public void ResetBall()
    {
        transform.position = startPos;
        rb.linearVelocity = Vector2.zero;
        Launch();
    }

    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1f : 1f;
        float y = Random.Range(0, 2) == 0 ? -1f : 1f;

        rb.linearVelocity = new Vector2(x, y).normalized * speed;
    }
}