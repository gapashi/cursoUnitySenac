using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playerVelocity;
    public float jumpPower = 10f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        this.Move();
        this.Jump();
    }

    private void Move()
    {
        float inputX = Input.GetAxis("Horizontal");
        //float inputY = Input.GetAxis("Vertical");

        //rb.linearVelocity = new Vector2 (inputX * playerVelocity, inputY * playerVelocity);
        rb.linearVelocityX = inputX * playerVelocity;
    }

    private void Jump()
    {
        bool jumpíng = Input.GetKeyDown(KeyCode.Space);

        if (jumpíng == true)
        {
            rb.linearVelocityY = jumpPower;
        }
    }
}
