using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    private GameObject[] argv;
    public Create(GameObject[] argv1)
    {
        
        this.argv = new GameObject[argv1.Length];
        for(int i = 0; i < argv1.Length; i++)
        {
            this.argv[i] = argv1[i];
        }
    }
    public void createHero()
    {
        for(int i = 0; i < 2; i++)
        {
            Instantiate(this.argv[i]);
        }
        this.argv[0].transform.position = new Vector2(-10f, -7f);
        this.argv[1].transform.position = new Vector2(this.argv[0].transform.position.x, this.argv[0].transform.position.y + 4.5f);
        
        
    }
    public void createEnemy()
    {
        for (int i = 2; i < argv.Length; i++)
        {
            Instantiate(this.argv[i]);
        }
        this.argv[2].transform.position = new Vector2(13.5f, Random.Range(5f, -5f));
        this.argv[3].transform.position = new Vector2(this.argv[2].transform.position.x, this.argv[2].transform.position.y + 6);
    }
}
