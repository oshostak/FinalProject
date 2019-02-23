using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPanelScript : MonoBehaviour
{
    // short script for the pause menu
    public void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
