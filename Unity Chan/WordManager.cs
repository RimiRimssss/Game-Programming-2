using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordManager : MonoBehaviour
{
    public WordBank wordBank = null; //hi sir
    public Text wordOutput = null;
    public Text scoreOutput = null; // Text component for displaying the score
    public Text timerOutput = null; // Text component for displaying the remaining time
    public Image wordImageOutput = null; // Image component for displaying the word's image
    public GameObject gameOverPanel = null; // Reference to the Game Over Panel
    public Text endGameScore = null; // Text component for displaying the end game score
    public Text highScore = null; // Text component for displaying the high score
    public AudioSource soundPoints;
    public AudioSource soundWrong;
    public AudioSource typing;

    private string remainingWord = string.Empty;
    private string currentWord = string.Empty;
    private int score = 0;
    private float remainingTime = 120f;
    private int highScoreValue = 0; // High score variable
    private Color incorrectColor = Color.red;
    private Color defaultColor = Color.black;

    void Start()
    {
        SetCurrentWord();
        UpdateScoreDisplay();
        UpdateTimerDisplay();

        // Load high score
        highScoreValue = PlayerPrefs.GetInt("HighScore", 0);
        gameOverPanel.SetActive(false);

    }

    void Update()
    {
        CheckInput();
        UpdateTimer();
    }

    private void CheckInput()
    {
        if (Input.anyKeyDown)
        {
            string keysPressed = Input.inputString;

            if (keysPressed.Length == 1)
                EnterLetter(keysPressed);
        }
    }

    private void EnterLetter(string typedLetter)
    {
        if (IsCorrectLetter(typedLetter))
        {
            RemoveLetter();
            wordOutput.color = defaultColor;

            if (IsWordComplete())
            {
                SetCurrentWord();
                IncrementScore();
                UpdateScoreDisplay();
            }
        }
        else
        {
            wordOutput.color = incorrectColor;
            DecrementScore();
            UpdateScoreDisplay();
        }
    }

    private bool IsCorrectLetter(string letter)
    {
        return remainingWord.IndexOf(letter) == 0;
        
    }

    private void RemoveLetter()
    {
        string newString = remainingWord.Remove(0, 1);
        SetRemainingWord(newString);
        typing.Play();
    }

    private bool IsWordComplete()
    {
        return remainingWord.Length == 0;
    }

    private void SetCurrentWord()
    {
        currentWord = wordBank.GetWord();
        SetRemainingWord(currentWord);
        SetWordImage(currentWord);
    }

    private void SetRemainingWord(string newString)
    {
        remainingWord = newString;
        wordOutput.text = remainingWord;
        wordOutput.color = defaultColor;
    }

    private void SetWordImage(string word)
    {
        Sprite wordImage = wordBank.GetImageForWord(word);
        if (wordImage != null)
        {
            wordImageOutput.sprite = wordImage;
        }
        else
        {
            wordImageOutput.sprite = null;
        }
    }

    private void IncrementScore()
    {
        score += 10;
        soundPoints.Play();
    }

    private void DecrementScore()
    {
        score -= 5;
        soundWrong.Play();
        if (score < 0)
        {
            score = 0;
        }
    }

    private void UpdateScoreDisplay()
    {
        scoreOutput.text = score.ToString();
    }

    private void UpdateTimer()
    {
        remainingTime -= Time.deltaTime;
        UpdateTimerDisplay();

        if (remainingTime <= 0)
        {
            EndGame();
        }
    }

    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        string formattedTime = $"{minutes}:{seconds:00}";
        timerOutput.text = formattedTime;
    }

    private void EndGame()
    {
        timerOutput.text = "Time's up!";

        // Check if a new high score was reached
        if (score > highScoreValue)
        {
            highScoreValue = score;
            PlayerPrefs.SetInt("HighScore", highScoreValue);
            PlayerPrefs.Save();
        }

        // Display the game over panel and update the score and high score
        gameOverPanel.SetActive(true);
        endGameScore.text = " " + score;
        highScore.text = " " + highScoreValue;
    }

    public void RetryGame()
    {
        // Reload the current scene to restart the game
        SceneManager.LoadScene("SampleScene");
    }

    public void MainMenu()
    {
        // Load the main menu scene
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }
}
