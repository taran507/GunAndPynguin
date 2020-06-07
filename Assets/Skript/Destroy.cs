using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    
    private void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("2");
    }
    private void OnTriggerEnter(Collider other)
    {
        print("1");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("3");
        
        //print("Destroy");
        //Destroy(txt.gameObject);
        
    }

}
