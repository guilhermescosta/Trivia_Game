using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameData _gamedata;
    public Text playerText;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        _gamedata = GameObject.FindGameObjectWithTag("Data").GetComponent<GameData>();
        // int points = _gamedata.points * 50 - (int) _gamedata.time;
        float points =  _gamedata.points * 50 - _gamedata.time;

        if (points < 0)
        {
            scoreText.text = "Resultado Final: " + 0;
        }
        else
        {
            scoreText.text = "Resultado Final: " + points;
        }


        playerText.text = "Nome da Equipe: " + _gamedata.playerName;
       
    }

    public void ReturnMainMenu() 
    {
        SceneManager.LoadScene(0);
    }
}
