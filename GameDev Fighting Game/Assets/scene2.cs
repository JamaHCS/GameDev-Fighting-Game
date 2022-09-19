using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scene2 : MonoBehaviour
{
    public TextMeshProUGUI p1Name;
    public TextMeshProUGUI p2Name;

    public TextMeshProUGUI p1HPUI;
    public TextMeshProUGUI p2HPUI;

    public int p1HP = 100;
    public int p2HP = 100;
    public void Awake(){
        p1Name.text = Scene1.scene1.player1Name;
        p2Name.text = Scene1.scene1.player2Name;
    }

    void Update()
    {
        Debug.Log(p1HP + "");

        p1HPUI.GetComponent<TMPro.TextMeshProUGUI>().text = "HP:" + p1HP;
        p2HPUI.GetComponent<TMPro.TextMeshProUGUI>().text = "HP:" + p2HP;
    }


    // Update is called once per frame

}
