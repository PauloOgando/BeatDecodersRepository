using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    #region Fields

    // Life lost support
    static List<WinConditionReviewer> lifeLostInvokers = new List<WinConditionReviewer>();
    static List<UnityAction> lifeLostListeners = new List<UnityAction>();

    // Game started support
    static List<LevelSelect> gameStartedInvokers = new List<LevelSelect>();
    static List<UnityAction<Levels>> gameStartedListeners = new List<UnityAction<Levels>>();

    // Last life lost support
    static List<HUD> lastLifeLostInvokers = new List<HUD>();
    static List<UnityAction> lastLifeLostListeners = new List<UnityAction>();

    #endregion

    #region Life Lost support

    /// <summary>
    /// Adds the given script as a life lost invoker
    /// </summary>
    /// <param name="invoker">invoker</param>
    public static void AddLifeLostInvoker(WinConditionReviewer invoker)
    {
        lifeLostInvokers.Add(invoker);
        foreach (UnityAction listener in lifeLostListeners)
        {
            invoker.AddLifeLostListener(listener);
        }
    }

    /// <summary>
    /// Adds the given method as a life lost listener
    /// </summary>
    /// <param name="listener">listener</param>
    public static void AddLifeLostListener(UnityAction listener)
    {
        lifeLostListeners.Add(listener);
        foreach (WinConditionReviewer invoker in lifeLostInvokers)
        {
            invoker.AddLifeLostListener(listener);
        }
    }

    #endregion

    #region Game Started support
    /// <summary>
    /// Adds the given script as a game started invoker
    /// </summary>
    /// <param name="invoker">invoker</param>
    public static void AddGameStartedInvoker(LevelSelect invoker)
    {
        gameStartedInvokers.Add(invoker);
        foreach (UnityAction<Levels> listener in gameStartedListeners)
        {
            invoker.AddGameStartedListener(listener);
        }
    }

    /// <summary>
    /// Adds the given method as a game started listener
    /// </summary>
    /// <param name="listener">listener</param>
    public static void AddGameStartedListener(UnityAction<Levels> listener)
    {
        gameStartedListeners.Add(listener);
        foreach (LevelSelect invoker in gameStartedInvokers)
        {
            invoker.AddGameStartedListener(listener);
        }
    }

    #endregion

    #region Last Life Lost support

    /// <summary>
    /// Adds the given script as a last life lost invoker
    /// </summary>
    /// <param name="invoker">invoker</param>
    public static void AddLastLifeLostInvoker(HUD invoker)
    {
        lastLifeLostInvokers.Add(invoker);
        foreach (UnityAction listener in lastLifeLostListeners)
        {
            invoker.AddLastLifeLostListener(listener);
        }
    }

    /// <summary>
    /// Adds the given method as a last life lost listener
    /// </summary>
    /// <param name="listener">listener</param>
    public static void AddLastLifeLostListener(UnityAction listener)
    {
        lastLifeLostListeners.Add(listener);
        foreach (HUD invoker in lastLifeLostInvokers)
        {
            invoker.AddLastLifeLostListener(listener);
        }
    }

    #endregion
}
