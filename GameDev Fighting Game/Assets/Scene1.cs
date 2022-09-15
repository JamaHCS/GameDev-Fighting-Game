using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene1 : MonoBehaviour
{
    // Start is called before the first frame update
    public static Scene1 scene1;
    public GameObject inputField;
    public GameObject inputField2;
    public static string player1Name;
    public static string player2Name;

    public Button button1;

    void Start (){

    }

    void Update () {

    }

    private void Awake(){

        if (scene1 == null){

            scene1 = this;
            DontDestroyOnLoad(gameObject);
            }

        else {
            Destroy(gameObject);
        }

    }

    public void setText(){


    }

    public void changeScene(){
        StartCoroutine(delayPress());
    }

    public IEnumerator delayPress(){

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
