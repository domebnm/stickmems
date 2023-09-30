using UnityEngine;

public class MouseForce : MonoBehaviour
{
    public FixedJoystick fixedJoystick;

    private Rigidbody2D rb;

    public float force = 10f;

    public float maxSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
            Vector2 forceVector = fixedJoystick.Direction * force;

            rb.AddForce(forceVector, ForceMode2D.Impulse);

            rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
    }
}
