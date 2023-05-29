using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class RegisterPlayer : MonoBehaviour
{
    public GameData _gamedata;
    public InputField playerName;
    //public TMP_InputField playerName;
    public Dropdown playerClass;



    public void RegisterButton() 
    {
        if(playerName.text!="") { 

            _gamedata.playerName = playerName.text;
            _gamedata.playerClass = playerClass.value.ToString();
            // Debug.Log(playerClass.options[playerClass.value].text);
       

            if (playerClass.value == 0)   // medio
            {
                SceneManager.LoadScene(3);
            }
            else if (playerClass.value == 1)   // 8-9
            {
                SceneManager.LoadScene(43);
            }
            else if (playerClass.value == 2)   // 6-7
            {
                SceneManager.LoadScene(23);
            }

        }
        else
        Debug.Log("Nome vazio");

        // SceneManager.LoadScene(3);



    }
}
