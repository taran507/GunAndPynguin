using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour
{
    // Start is called before the first frame update
    private int r1;
    public Text rec;
    
    void Start()
    {
        r1 = 0;
        rec.GetComponent<Text>();
        UpdateRec();
        //print(rec.text);
    }
    void UpdateRec()
    {
        rec.text = "Рекорд: " + r1;
    }
    public void addRec(int r2)
    {
        r1 += r2;
        UpdateRec();
    }
}
