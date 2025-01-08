using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionAccomplishedMessage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    /// <summary>
    /// Handles the levels button
    /// </summary>
    public void HandleLevelsButton()
    {
        Time.timeScale = 1;
        Destroy(gameObject);
        MenuManager.GoToMenu(MenuName.LevelSelect);
    }

    /// <summary>
    /// Handles the quit button
    /// </summary>
    public void HandleQuitButton()
    {
        Time.timeScale = 1;
        Destroy(gameObject);
        MenuManager.GoToMenu(MenuName.MainMenu);
    }
}
