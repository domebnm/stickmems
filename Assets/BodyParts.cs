using UnityEngine;

public class BodyParts : MonoBehaviour
{
    public float damage;
    public float force;
    public Person person;
    private Rigidbody2D rb;

    private void Start()
    {
        this.gameObject.tag = person.gameObject.tag;
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag != this.tag && collision.collider.tag != "Untagged")
        {
            person.ColliderDetect(damage);
            Vector2 direction = (this.transform.position - collision.transform.position).normalized;
            rb.AddForce(direction * collision.gameObject.GetComponent<BodyParts>().force, ForceMode2D.Impulse);
            if (damage != 0)StartCoroutine(TimeScaleGame.TimeScale());
        }
    }
}
