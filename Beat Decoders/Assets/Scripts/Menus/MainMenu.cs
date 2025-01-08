using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject mainCanvas;
    [SerializeField]
    GameObject prefabDigitalBackground;

    // Animation time duration for the scene change
    [SerializeField] AnimationClip sceneChangeAnimation;
    Timer sceneChangeTimer;

    // Start is called before the first frame update
    void Start()
    {
        AudioManager.Play(AudioClipName.BeatDecodersMenu);
        sceneChangeTimer = gameObject.AddComponent<Timer>();
        sceneChangeTimer.Duration = sceneChangeAnimation.length / 1.25f;
        sceneChangeTimer.AddTimerFinishedListener(HandleTimerFinishedEvent);
    }

    /// <summary>
    /// Handles the click event from the Play button
    /// </summary>
    public void HandlePlayButtonOnClickEvent()
    {
        sceneChangeTimer.Run();
        GameObject DBG = Instantiate(prefabDigitalBackground);
        DBG.transform.SetParent(mainCanvas.transform, false);
    }

    /// <summary>
    /// Handles the timer finished event
    /// </summary>
    void HandleTimerFinishedEvent()
    {
        MenuManager.GoToMenu(MenuName.LevelSelect);
    }

    /// <summary>
    /// Handles the click event from the Quit button
    /// </summary>
    public void HandleQuitButtonOnClickEvent()
    {
        Application.Quit();
    }
}
