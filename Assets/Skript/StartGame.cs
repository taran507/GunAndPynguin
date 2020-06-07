using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Animation anim1;
    public GameObject[] gameObjects;
    /*public GameObject actor_plane;
    public GameObject enemy_plane;
    public GameObject actor;
    public GameObject enemy;*/
    public GameObject txt;
    private create create;
    private RectTransform rt;
    private bool sost;
    private void Start()
    {
        rt = GetComponent<RectTransform>();
        /*actor_plane.GetComponent<GameObject>();
        enemy_plane.GetComponent<GameObject>();
        actor.GetComponent<GameObject>();
        enemy.GetComponent<GameObject>();*/
        txt.GetComponent<GameObject>();
        /*actor_plane.name = "actor_plane";
        enemy_plane.name = "enemy_plane";*/
        //actor.name = "actor";
        //enemy.name = "enemy";
        anim1.GetComponent<Animation>();
        
        
    }
    IEnumerator MyCorutine()
    {
        yield return new WaitForSeconds(2f);
    }
    private void OnMouseDown()
    {

        anim1.Play();
        StartCoroutine(MyCorutine());
        create = new create(gameObjects.Length, gameObjects);
        create.createLvl();
       
        sost = true;
        print("Start");
    }
    private void FixedUpdate()
    {
        if (sost)
        {
            if (rt.offsetMax.y != -220f)
            {
                rt.offsetMin -= new Vector2(rt.offsetMin.x, 10);
                rt.offsetMax -= new Vector2(rt.offsetMax.x, 10);
            }
            else
            {
                Destroy(txt,1f);
                Destroy(rt.gameObject,1f);
            }
        }
        
    }


}
