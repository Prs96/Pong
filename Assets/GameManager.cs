using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;
    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;
    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;
    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;
    
    private int Player1Score;
    private int Player2Score;

    // Cached component references for better performance
    private Ball ballComponent;
    private Paddle player1PaddleComponent;
    private Paddle player2PaddleComponent;
    private TextMeshProUGUI player1TextComponent;
    private TextMeshProUGUI player2TextComponent;

    void Start()
    {
        CacheComponents();
    }

    private void CacheComponents()
    {
        // Cache Ball component
        if (ball != null)
            ballComponent = ball.GetComponent<Ball>();
        else
            Debug.LogError("Ball GameObject is not assigned!");

        // Cache Paddle components
        if (player1Paddle != null)
            player1PaddleComponent = player1Paddle.GetComponent<Paddle>();
        else
            Debug.LogError("Player1Paddle GameObject is not assigned!");

        if (player2Paddle != null)
            player2PaddleComponent = player2Paddle.GetComponent<Paddle>();
        else
            Debug.LogError("Player2Paddle GameObject is not assigned!");

        // Cache Text components
        if (Player1Text != null)
            player1TextComponent = Player1Text.GetComponent<TextMeshProUGUI>();
        else
            Debug.LogError("Player1Text GameObject is not assigned!");

        if (Player2Text != null)
            player2TextComponent = Player2Text.GetComponent<TextMeshProUGUI>();
        else
            Debug.LogError("Player2Text GameObject is not assigned!");
    }

    public void Player1Scored()
    {
        Player1Score++;
        if (player1TextComponent != null)
        {
            player1TextComponent.text = Player1Score.ToString();
        }
        ResetPosition();
    }

    public void Player2Scored()
    {
        Player2Score++;
        if (player2TextComponent != null)
        {
            player2TextComponent.text = Player2Score.ToString();
        }
        ResetPosition();
    }

    private void ResetPosition()
    {
        if (ballComponent != null)
            ballComponent.Reset();

        if (player1PaddleComponent != null)
            player1PaddleComponent.Reset();

        if (player2PaddleComponent != null)
            player2PaddleComponent.Reset();
    }
}
