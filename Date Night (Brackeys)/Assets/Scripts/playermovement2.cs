using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement2 : MonoBehaviour
{
    public float speed2;
    public float jumpForce2;
    private float moveInput;

    private Rigidbody2D rb;

    private bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck2;
    public float checkRadius2;
    public LayerMask whatIsGround2;

    private int extraJumps;
    public int extraJumpsValue2;

    public GameObject DeathParticle;
    public GameObject Deads;

    bool dead = false;


    private void Start()
    {
        extraJumps = extraJumpsValue2;
        rb = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck2.position, checkRadius2, whatIsGround2);



        moveInput = Input.GetAxis("Horizontal2");
        rb.velocity = new Vector2(moveInput * speed2, rb.velocity.y);

        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }

    private void Update()
    {
        if (isGrounded == true)
        {
            extraJumps = extraJumpsValue2;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce2;
            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce2;
        }

        if (transform.position.y <= -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (dead == true)
        {
            Deads.tag = "true";
            Instantiate(DeathParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            dead = true;
        }
    }

    void Dead()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
