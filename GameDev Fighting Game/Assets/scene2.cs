using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene2 : MonoBehaviour
{
    public GameObject p1Name;
    public GameObject p2Name;
    public GameObject p1HPUI;
    public GameObject p2HPUI;

    public int p1HP = 100;
    public  int p2HP = 100;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        p1HPUI.GetComponent<TMPro.TextMeshProUGUI>().text = p1HP + "";
        p1HPUI.GetComponent<TMPro.TextMeshProUGUI>().text = p1HP + "";
    }
}
