using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    private GameObject[] argv;
    public Create(int argc, GameObject[] argv1)
    {
        
        this.argv = new GameObject[argc];
        for(int i = 0; i < argc; i++)
        {
            this.argv[i] = argv1[i];
        }
    }
    public void createLvl()
    {
        for(int i = 0; i < this.argv.Length; i++)
        {
            Instantiate(this.argv[i]);
            //this.argv[i].transform.localScale = new Vector2(5, 5);
        }
        this.argv[0].transform.position = new Vector2(-10f, -7f);
        this.argv[1].transform.position = new Vector2(this.argv[0].transform.position.x, this.argv[0].transform.position.y + 4.5f);
        this.argv[2].transform.position = new Vector2(13.5f, Random.Range(5f, -5f));
        this.argv[3].transform.position = new Vector2(this.argv[2].transform.position.x, this.argv[2].transform.position.y + 6);
    }
}
