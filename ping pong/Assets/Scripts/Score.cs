using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreBoard;
    public GameObject ball;

    private int player1Score = 0;
    private int player2Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("ball");


    }

    private void Update()
    {
        if (ball.transform.position.x >= 10.75f)
        {
            player1Score++;
        }
        if(ball.transform.position.x <= -10.75f)
        {
            player2Score++;
        }

        ScoreBoard.text = player1Score.ToString() + "-" + player2Score.ToString(); 
    }


}
