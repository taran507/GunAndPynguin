using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    
    private GameController gameController;
    public GameObject Death;
    private void Start()
    {
        Death.GetComponent<GameObject>();
        GameObject GameControllerObject = GameObject.FindWithTag("Record");
        if (GameControllerObject != null)
        {
            gameController = GameControllerObject.GetComponent<GameController>();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Core")
        {
            gameController.AddScore();
            Destroy(Death);
        }
    }
}
