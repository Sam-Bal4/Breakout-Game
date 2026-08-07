using UnityEngine;

public class BouncyBall : MonoBehaviour
{
    public float minY = -5.5f; //Used to check if the ball falls below the platform
    public float maxVelocity = 20f; //Used to limit the ball's speed

    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Need this to change the ball's velocity
    }

    // Update is called once per frame
    void Update()
    {
        //If the ball falls below the paddle, reset its position and speed
        if(transform.position.y < minY){
            transform.position = Vector3.zero;
            rb.linearVelocity = Vector2.zero;
        }

        //If the ball's speed exceeds the limit, clamp it to the maximum speed
        if(rb.linearVelocity.magnitude > maxVelocity){
            rb.linearVelocity = Vector3.ClampMagnitude(rb.linearVelocity, maxVelocity);
        }
    }

    //Check if the ball collides with a brick, if it does, delete it
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Brick")){
            Destroy(collision.gameObject);
        }
    }
}
