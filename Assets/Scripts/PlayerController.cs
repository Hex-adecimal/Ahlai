using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    // Bad Place Commands
    private float lastInput = 0;

    // Good Place Commands
    private float jumpForce = 600f;
    private bool isGrounded = true;
    private bool isSwiping = false;
    private Vector2 startPos;
    private Vector2 direction;
    private float thresHold = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastInput > 3)
        {
            rb.AddForce(new Vector2(10, 0));
            
        }

        if (Input.touchCount > 0)
        {
            
            //rb.AddForce(new Vector2(-20, 0));
            lastInput = Time.time;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Right Border"))
        {
            Destroy(gameObject.gameObject);
        }
    }
}

/*
 * Touch touch = Input.GetTouch(0);
 * switch (touch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                    Debug.Log("New touch");
                    startPos = touch.position;
                    direction = new Vector2(0, 0);
                    isSwiping = false;
                    break;

                // Determine direction by comparing the current touch position with the initial one.
                case TouchPhase.Moved:
                    Debug.Log("Changed direction");
                    direction = touch.position - startPos;
                    isSwiping = true;
                    break;

                // Report that a direction has been chosen when the finger is lifted.
                case TouchPhase.Ended:
                    Debug.Log("Ended touch");
                    // Actions
                    if (isGrounded)
                    {
                        // Jump
                        if (!isSwiping)
                        {
                         
                            rb.AddForce(Vector2.up * jumpForce);
                            isGrounded = false;
                        }

                        if (isSwiping)
                        {
                            // Higher Jump
                            if (direction.y > thresHold)
                            {
                                rb.AddForce(Vector2.up * 2 * jumpForce);
                                isGrounded = false;
                                isSwiping = false;
                            }

                            if (direction.y < -thresHold)
                            {
                                //TODO: Roll down

                                isSwiping = false;
                            }
                        }
                    }
                    break;
            }*/