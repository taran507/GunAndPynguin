using System;
using UnityEngine;
using UnityEngine.UI;


public class fly : MonoBehaviour
{
    //public Text txt;
    public float speed = 10f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = new Vector2(speed*(float)Math.Cos((rb.rotation+7.5) * Math.PI / 180), speed * (float)Math.Sin((rb.rotation+7.5) * Math.PI / 180));
    }
    void Update()
    {
        if (rb.position.y < -12 || rb.position.x > 20)
        {
            Destroy(rb.gameObject);
        }
    }
    
}
