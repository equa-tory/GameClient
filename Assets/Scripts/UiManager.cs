using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    public static UiManager Instance;

    public GameObject startMenu;
    public TMP_InputField usernameField;

    private void Awake() {
        if(Instance == null) Instance = this;
        else if (Instance!=this){
            Debug.Log("Instance already exists, destroying object");
            Destroy(this);
        }
    }
    
    public void ConnectToServer()
    {
        startMenu.SetActive(false);
        usernameField.interactable = false;
        Client.Instance.ConnectToServer();
    }
}
