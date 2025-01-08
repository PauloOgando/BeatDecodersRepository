using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Depending on the selected level, the game will start with the selected level
/// </summary>
public class GameStartedEvent : UnityEvent<Levels>
{
}
