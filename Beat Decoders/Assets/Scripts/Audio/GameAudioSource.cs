using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An audio source for the game
/// </summary>
public class GameAudioSource : MonoBehaviour
{
    /// <summary>
    /// Awake is called before Start
    /// </summary>
    void Awake()
    {
        // Make sure to only have one audio source in the game
        if(!AudioManager.Initialized)
        {
            AudioSource audioSource = gameObject.AddComponent<AudioSource>();
            AudioManager.Initialize(audioSource);
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
