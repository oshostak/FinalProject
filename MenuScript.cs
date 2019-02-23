using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//this scripts is similar for all the menues because it features all the menu functions 
public class MenuScript : MonoBehaviour
{
    public int counter;

    public void Start()
    {
        counter = 0;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void MainMenu()  
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }
}
