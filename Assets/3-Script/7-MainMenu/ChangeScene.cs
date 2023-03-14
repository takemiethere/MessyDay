using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    /*public GameObject[] UiElements;

    public void ActiveElements()
    {

    }*/

    public void GotoScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
