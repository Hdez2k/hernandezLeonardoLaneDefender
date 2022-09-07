using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;

    public int lives;
    public TMP_Text livesText;

    private void Start()
    {
        livesText.text = "Lives: " + lives;
        livesText.text = "Score: " + score;

    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if (Input.GetKey(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }

    public void UpdateScore(int number)
    {
        score += number;
    }
    public void LoseLife()
    {
        lives--;
        livesText.text = "Lives: " + lives;
    }
}