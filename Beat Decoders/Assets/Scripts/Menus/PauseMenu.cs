using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    /// <summary>
    /// Resumes the game
    /// </summary>
    public void Resume()
    {
        Time.timeScale = 1;
        Destroy(gameObject);
    }

    /// <summary>
    /// Quits the game
    /// </summary>
    public void Quit()
    {
        Time.timeScale = 1;
        Destroy(gameObject);
        MenuManager.GoToMenu(MenuName.MainMenu);
    }
}
