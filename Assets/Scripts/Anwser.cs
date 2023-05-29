using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Anwser : MonoBehaviour
{
    public Question _question;


    public bool rightAnwser;
    public bool isClicked;


    public GameObject confirmButton;


    public void ClickButton() 
    {
        Button b = this.GetComponent<Button>();
        ColorBlock cb = b.colors;
        cb.selectedColor = Color.yellow;
        b.colors = cb;

        isClicked = true;

        if (rightAnwser == true) 
        {
            Debug.Log("OK");
        }

        confirmButton.SetActive(true);
    }



    
}
