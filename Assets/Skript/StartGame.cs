using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Animation anim1;
    public GameObject[] gameObjects;
    public GameObject txt;
    private Create create;
    private RectTransform rt;
    private bool sost;
    private void Start()
    {
        rt = GetComponent<RectTransform>();
        txt.GetComponent<GameObject>();
        anim1.GetComponent<Animation>();
        
    }
    IEnumerator MyCorutine()
    {
        yield return new WaitForSeconds(10f);
    }
    private void OnMouseDown()
    {

        anim1.Play();
        StartCoroutine(MyCorutine());
        create = new Create(gameObjects);
        create.createHero();
        create.createEnemy();
        sost = true;
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
