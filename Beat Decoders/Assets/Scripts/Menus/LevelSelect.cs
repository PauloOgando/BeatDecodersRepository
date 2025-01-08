using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelSelect : MonoBehaviour
{
    GameStartedEvent gameStartedEvent = new GameStartedEvent();

    void Start()
    {
        EventManager.AddGameStartedInvoker(this);
    }

    public void AddGameStartedListener(UnityAction<Levels> listener)
    {
        gameStartedEvent.AddListener(listener);
    }

    public void StartFirstLevel()
    {
        gameStartedEvent.Invoke(Levels.Level1);
    }

    public void StartSecondLevel()
    {
        gameStartedEvent.Invoke(Levels.Level2);
    }

    public void StartThirdLevel()
    {
        gameStartedEvent.Invoke(Levels.Level3);
    }

    public void StartFourthLevel()
    {
        gameStartedEvent.Invoke(Levels.Level4);
    }

    public void StartFifthLevel()
    {
        gameStartedEvent.Invoke(Levels.Level5);
    }
}
