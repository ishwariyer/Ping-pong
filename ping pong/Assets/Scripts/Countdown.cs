using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Text countdownText;
    public float startingTime = 5f;
    private float currentTime = 0f;
    [SerializeField] bool IsPaddleOn = false;
    public PaddleLeft paddleleft;
    public PaddleRight paddleRight;
    public Puck ball;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        countdownText.text = currentTime.ToString("0");
        if(currentTime <= 0)
        {
            currentTime = 0;
            if (IsPaddleOn == false)
            {
                IsPaddleOn = true;

                paddleleft.isPlayer1 = true;
                paddleRight.isPlayer2 = true;
                ball.isPlayerBall = true;
            }
            countdownText.enabled = false;
        }

        
    }
}
