using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AudioManager
{
    static bool initialized = false;
    static AudioSource audioSource;
    static Dictionary<AudioClipName, AudioClip> audioClips = new Dictionary<AudioClipName, AudioClip>();

    /// <summary>
    /// Gets wheter or not the audio manager has been initialized
    /// </summary>
    public static bool Initialized
    {
        get { return initialized; }
    }

    /// <summary>
    /// Initializes the audio manager
    /// </summary>
    /// <param name="source">Audio source</param>
    public static void Initialize(AudioSource source)
    {
        initialized = true;
        audioSource = source;
        audioClips.Add(AudioClipName.BeatDecodersMenu, Resources.Load<AudioClip>("BeatDecodersMenu"));
        audioClips.Add(AudioClipName.WeWillRockYouKick, Resources.Load<AudioClip>("WeWillRockYouKick"));
        audioClips.Add(AudioClipName.WeWillRockYouSnare, Resources.Load<AudioClip>("WeWillRockYouSnare"));
    }

    /// <summary>
    /// Plays the audio clip
    /// </summary>
    /// <param name="name">Name of the audio clip</param>
    public static void Play(AudioClipName name)
    {
        audioSource.PlayOneShot(audioClips[name]);
    }

    /// <summary>
    /// Stops the audio clip
    /// </summary>
    /// <param name="name">Name of the audio clip</param>
    public static void Stop(AudioClipName name)
    {
        audioSource.Stop();
    }
}
