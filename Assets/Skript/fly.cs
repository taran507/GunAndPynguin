using System;
using UnityEngine;

public class fly : MonoBehaviour
{

    public float speed = 10f;
    public Rigidbody2D rb;
    void Start()
    {
        print(rb.rotation+7.5);
        rb.velocity = new Vector2(speed*(float)Math.Cos((rb.rotation+7.5) * Math.PI / 180), speed * (float)Math.Sin((rb.rotation+7.5) * Math.PI / 180));
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
