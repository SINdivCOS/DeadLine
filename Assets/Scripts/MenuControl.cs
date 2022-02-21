using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public void GoToOptionScreen()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToInfoScreen()
    {
        SceneManager.LoadScene("InfoScreen");
    }

    public void GoToHeroScreen()
    {
        SceneManager.LoadScene("HeroScreen");
    }

    public void GoToPlayGame()
    {
        SceneManager.LoadScene("PlayGame");
    }

    public void GoToShopScreen()
    {
        SceneManager.LoadScene("ShopScreen");
    }

    public void BackToHome()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)==true)
        {
            Application.Quit();
        }
    }
}
