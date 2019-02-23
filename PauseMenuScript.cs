using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{

    //need to import pauseMenuUI to operate. also setting up a public bool so that everyone will answer and see
    public static bool isGamePaused = false;
    public GameObject pauseMenuUI;


    //checks if any key is presse
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                ResumeGame();
            }

            else
            {
                PauseGame();
            }
        }

    }

    //the next functions are mostly with time stop algorythms and modification of isGamPaused bool variable
    public void ResumeGame()  
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;

    }

    void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        isGamePaused = false;
    }
}
