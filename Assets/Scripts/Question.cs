using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;

    public Text timerText;
    public float timer;
    

    public GameData _gamedata;

    public bool isPlaying;

    public int sceneIndex;

   

    public void Start()
    {
        isPlaying = true;
        _gamedata = GameObject.FindGameObjectWithTag("Data").GetComponent<GameData>();
    }
    private void Update()
    {
        if (isPlaying)
        {
            timer += Time.deltaTime;
            float minutes = Mathf.Floor(timer / 60.0f);
            float seconds = timer - minutes * 60.0f;
            timerText.text = "Tempo: " + string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
    public void NextQuestion() 
    {
        if (button1.GetComponent<Anwser>().rightAnwser == true) 
        {
            Button b = button1.GetComponent<Button>();
            ColorBlock cb = b.colors;
            cb.normalColor = Color.green;
            b.colors = cb;

             b = button2.GetComponent<Button>();
             cb = b.colors;
            cb.normalColor = Color.red;
            b.colors = cb;

            b = button3.GetComponent<Button>();
            cb = b.colors;
            cb.normalColor = Color.red;
            b.colors = cb;

            b = button4.GetComponent<Button>();
            cb = b.colors;
            cb.normalColor = Color.red;
            b.colors = cb;

            if (button1.GetComponent<Anwser>().isClicked)
            {
                _gamedata.points++;
            }
        }

        else  if (button2.GetComponent<Anwser>().rightAnwser == true)
        {
            Button b = button2.GetComponent<Button>();
            ColorBlock cb = b.colors;
            cb.normalColor = Color.green;
            b.colors = cb;

            b = button1.GetComponent<Button>();
            cb = b.colors;
            cb.normalColor = Color.red;
            b.colors = cb;

            b = button3.GetComponent<Button>();
            cb = b.colors;
            cb.normalColor = Color.red;
            b.colors = cb;

            b = button4.GetComponent<Button>();
            cb = b.colors;
            cb.normalColor = Color.red;
            b.colors = cb;

            if (button2.GetComponent<Anwser>().isClicked)
            {
                _gamedata.points++;
            }
        }

        else if (button3.GetComponent<Anwser>().rightAnwser == true)
        {
            Button b = button3.GetComponent<Button>();
            ColorBlock cb = b.colors;
            cb.normalColor = Color.green;
            b.colors = cb;

            b = button1.GetComponent<Button>();
            cb = b.colors;
            cb.normalColor = Color.red;
            b.colors = cb;

            b = button2.GetComponent<Button>();
            cb = b.colors;
            cb.normalColor = Color.red;
            b.colors = cb;

            b = button4.GetComponent<Button>();
            cb = b.colors;
            cb.normalColor = Color.red;
            b.colors = cb;

            if (button3.GetComponent<Anwser>().isClicked)
            {
                _gamedata.points++;
            }
        }

        else if (button4.GetComponent<Anwser>().rightAnwser == true)
        {
            Button b = button4.GetComponent<Button>();
            ColorBlock cb = b.colors;
            cb.normalColor = Color.green;
            b.colors = cb;

            b = button1.GetComponent<Button>();
            cb = b.colors;
            cb.normalColor = Color.red;
            b.colors = cb;

            b = button2.GetComponent<Button>();
            cb = b.colors;
            cb.normalColor = Color.red;
            b.colors = cb;

            b = button3.GetComponent<Button>();
            cb = b.colors;
            cb.normalColor = Color.red;
            b.colors = cb;

            if (button4.GetComponent<Anwser>().isClicked)
            {
                _gamedata.points++;
            }
        }
        isPlaying = false;

        _gamedata.time += timer;
       

        StartCoroutine("time");

    }

    IEnumerator time()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(sceneIndex);
        }
    }
   

}
