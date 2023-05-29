using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public string playerName;
    public string playerClass;
    public int points;
    public float time;

    public void Start()
    {
        DontDestroyOnLoad(this);
    }
}
