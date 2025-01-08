using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages navigation between menus and scenes
/// </summary>
public static class MenuManager
{
    /// <summary>
    /// Goes to the menu of the given name
    /// </summary>
    /// <param name="menuName">name of the menu to go to</param>
    public static void GoToMenu(MenuName name)
    {
        switch (name)
        {
            case MenuName.MainMenu:
                // go to the main menu
                SceneManager.LoadScene("MainMenu");
                break;
            case MenuName.LevelSelect:
                // go to the level select menu
                SceneManager.LoadScene("LevelSelect");
                break;
            case MenuName.Pause:
                // go to the pause menu
                Object.Instantiate(Resources.Load("PauseMenu"));
                break;
        }
    }
}
