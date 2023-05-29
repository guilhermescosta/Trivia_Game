using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendToGoogle : MonoBehaviour
{
    public GameData _gamedata;
    public EndGame endGame;

    public string equipe;
    public string classe;
    public string pontuacao;

    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/u/2/d/e/1FAIpQLScuJbymkWCkH-wfyzij0q2SfB74NBwHt7OcMlPQMk83cyrC5w/formResponse";

    public void Start()
    {
        _gamedata = GameObject.FindGameObjectWithTag("Data").GetComponent<GameData>();
        SendData();
    }
    IEnumerator Post(string equipe, string classe, string pontuacao) 
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.863352159", equipe);
        form.AddField("entry.1378901751", classe);
        form.AddField("entry.1853521836", pontuacao);

        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;
    }

    public void SendData() 
    {
        equipe = _gamedata.playerName;
        // classe
        if (_gamedata.playerClass == "0") 
        {
            classe = "Medio";
        }
        else if (_gamedata.playerClass == "1")
        {
            classe = "8 e 9 ano";
        }
        else if (_gamedata.playerClass == "2")
        {
            classe = "6 e 7 ano";
        }
        //pontuacao
        float points = _gamedata.points * 50 - _gamedata.time;
        if (points < 0) points = 0;
        pontuacao = points.ToString();

        StartCoroutine(Post(equipe, classe, pontuacao));
    }
}
