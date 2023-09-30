using UnityEngine;

public class Person : MonoBehaviour
{
    public float health;
    public SpriteRenderer spriteRenderer;
    public float healthScale;

    private void Start()
    {
        healthScale = 1 / health;
    }
    public void ColliderDetect(float damage)
    {
        health -= damage;
        spriteRenderer.material.color += new Color(healthScale * damage, 0f, 0f, 0f);
    }
}
