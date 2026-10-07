using UnityEngine;

public class Players : MonoBehaviour
{
    public bool player1;
    public float speed = 3f;
    public Rigidbody2D rb;

    private float move;
    private Vector3 startPos;

    private void Awake()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }

        startPos = transform.position;
    }

    private void Update()
    {
        move = Input.GetAxisRaw(player1 ? "Vertical" : "Vertical2");
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(0f, move * speed);
    }

    public void ResetPlayer()
    {
        move = 0f;
        rb.linearVelocity = Vector2.zero;
        rb.angularVelocity = 0f;
        transform.position = startPos;
    }
}