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
        if (Input.GetMouseButton(0))
        {
            var mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition); //положение мыши из экранных в мировые координаты
            var angle = Vector2.Angle(Vector2.right, mousePosition - transform.position);//угол между вектором от объекта к мыше и осью х
            transform.eulerAngles = new Vector3(0f, 0f, transform.position.y < mousePosition.y ? angle : -angle);//немного магии на последок
        }
    }
}

