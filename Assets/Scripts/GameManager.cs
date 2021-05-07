using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Text ScoreText,Highscore;
    float Score;
    float scorepersecomd;
    public Transform Player;
    public GameObject MainMenu;
    void Start()
    {
        Time.timeScale = 0;
        Score = 0;
        scorepersecomd = 1;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " +(int) Score;
        Score += scorepersecomd * Time.deltaTime;
        
        if ((int)Score > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", (int)Score);
        }
        Highscore.text ="Highscore: " + PlayerPrefs.GetInt("highscore").ToString();
    }
   
    public void StartGame()
    {
        Time.timeScale = 1;
        MainMenu.SetActive(false);
    }

}
