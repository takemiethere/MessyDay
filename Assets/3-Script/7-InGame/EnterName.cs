using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EnterName : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TextMeshProUGUI nameDisplay;
    public GameObject[] UiIDcard;
    public GameObject buttonObject;

    private string playerName = "";

    public void OnNameEntered()
    {
        playerName = nameInput.text;

        if (!string.IsNullOrEmpty(playerName))
        {
            nameDisplay.SetText(playerName);
            nameDisplay.gameObject.SetActive(true);
            buttonObject.SetActive(true);
        }
        UiIDcard[2].SetActive(false);
    }

    public void proIDcard()
    {
        UiIDcard[0].SetActive(false);
        UiIDcard[1].SetActive(true);
    }

    private void Start()
    {
        UiIDcard[0].SetActive(true);
        UiIDcard[1].SetActive(false);
    }
}
