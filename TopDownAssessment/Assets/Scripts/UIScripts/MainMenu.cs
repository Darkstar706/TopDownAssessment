﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int Lives = 10;
    public void startGame()
    {
        SceneManager.LoadScene("Lvl1");
        PlayerPrefs.SetInt("Lives", Lives);
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
