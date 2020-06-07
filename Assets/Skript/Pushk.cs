using System;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.UI;

public class Pushk : MonoBehaviour
{
    public GameObject yadro;
    public Transform FirePoint;
    private void Start()
    {
        FirePoint.GetComponent<Transform>();
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            yadro.GetComponent<GameObject>();
            Instantiate(yadro,FirePoint.position,FirePoint.rotation);
        }
    }
    private void Update()
    {
        
    }
}
