using System;
using UnityEngine;

public class fly : MonoBehaviour
{

    public float speed = 10f;
    public float angle = 45f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = new Vector2(speed, speed * (float)Math.Sin(angle*Math.PI/180));
    }
    void Update()
    {
        if (rb.position.y < -12 || rb.position.x > 20)
        {
            Destroy(rb.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(this);
            Destroy(collision.gameObject);
            print("Destroy");
        }
        
    }
}
