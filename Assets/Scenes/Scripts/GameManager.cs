using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject ball,highScoreText,scoreText;
    [SerializeField] Vector3 startPos;
    [SerializeField] Rigidbody2D left,right;

    int score, highscore;
    public int multiplier;
    public bool play;
    

    public static GameManager instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        Time.timeScale = 1;
        score= 0;
        multiplier= 1;
        highscore = PlayerPrefs.HasKey("HighScore")? PlayerPrefs.GetInt("HighScore"):0;
        highScoreText.GetComponent<Text>().text = "HighScore : " + highscore;
        play = false;

    }
    private void Update()
    {
        if (!play) return;
        if(Input.GetKey(KeyCode.A))
        {
            
        }
        else
        {

        }
        if (Input.GetKey(KeyCode.D))
        {

        }
        else
        {

        }

        left.AddTorque(25f);
        right.AddTorque(-25f);
    }

    public void GameStart()
    {
        highScoreText.SetActive(false);
        scoreText.SetActive(true);
        Instantiate(ball,startPos,Quaternion.identity);
        play= true;
    }

    public void UpdateScore(int point,int multiIncrease)
    {
        multiplier += multiIncrease;
        score+= point * multiplier;
        scoreText.GetComponent<Text>().text = "Score : " + score;
    }

    public void GameEnd()
    {
        Time.timeScale = 0;
        highScoreText.SetActive(true);
        if(score>highscore) 
        {
            PlayerPrefs.SetInt("HighScore", score);
            highscore= score;
        }
        highScoreText.GetComponent<Text>().text = "HighScore : " + highscore;
    }

}
