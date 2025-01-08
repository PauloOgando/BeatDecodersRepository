using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMessage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    public void HandleQuitButton()
    {
        Time.timeScale = 1;
        Destroy(gameObject);
        MenuManager.GoToMenu(MenuName.MainMenu);
    }
}
