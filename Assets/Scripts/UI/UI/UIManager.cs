using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingMenu;
    public GameObject pauseMenu;
    public GameObject inGameScreen;
    public GameObject winnerScreen;
    public GameObject gameOverScreen;
    LevelBar levelBar;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Winner();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GameOver();
        }

    }

    public void StartButton()
    {
        // SceneManager.LoadScene(1); 
        Debug.Log("Game Playing");
        TimeControl.instance.BeginGame();
        Time.timeScale = 1;
        mainMenu.SetActive(false);
        inGameScreen.SetActive(true);
    }
    public void SettingButton()
    {
        mainMenu.SetActive(false);
        settingMenu.SetActive(true);
    }
    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }
    public void PauseButton()
    {
        Time.timeScale = 0;
        inGameScreen.SetActive(false);
        pauseMenu.SetActive(true);  
    }
    public void ResumeButton()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        inGameScreen.SetActive(true);
    }
    public void Winner()
    {
        inGameScreen.SetActive(false);
        winnerScreen.SetActive(true);
        TimeControl.instance.GameOver();
    }
    public void NextLevelButton()
    {
        Debug.Log("Next Level!");
        SceneManager.LoadScene(1);
        inGameScreen.SetActive(true);
        winnerScreen.SetActive(false);
        TimeControl.instance.BeginGame();
        levelBar.SetLevelText();
    }
    public void RestartButton()
    {
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene(0);
    }
    public void GameOver()
    {
        inGameScreen.SetActive(false);
        gameOverScreen.SetActive(true);
        TimeControl.instance.GameOver();
        Time.timeScale = 0f;
    }
}
