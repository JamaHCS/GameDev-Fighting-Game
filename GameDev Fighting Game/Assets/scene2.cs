using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scene2 : MonoBehaviour
{
    public TextMeshProUGUI p1Name;
    public TextMeshProUGUI p2Name;
    public GameObject p1HPUI;
    public GameObject p2HPUI;

    public int p1HP = 100;
    public int p2HP = 100;


    void Start()
    {
        
    }

    public void Awake(){
        p1Name.text = Scene1.scene1.player1Name;
        p2Name.text = Scene1.scene1.player2Name;
    }

    // Update is called once per frame
    void Update()
    {
        p1HPUI.GetComponent<TMPro.TextMeshProUGUI>().text = p1HP + "";
        p2HPUI.GetComponent<TMPro.TextMeshProUGUI>().text = p2HP + "";
        
    }
}
