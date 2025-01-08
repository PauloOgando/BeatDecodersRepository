using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LevelSelectUtils
{
    #region Fields

    static Levels levelSelected;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the number of instruments in the code
    /// </summary>
    public static float numberOfInstruments
    {
        get { 
            switch (levelSelected)
            {
                case Levels.Level1:
                    return ConfigurationUtils.FirstLevelInstruments;
                case Levels.Level2:
                    return ConfigurationUtils.SecondLevelInstruments;
                case Levels.Level3:
                    return ConfigurationUtils.ThirdLevelInstruments;
                case Levels.Level4:
                    return ConfigurationUtils.FourthLevelInstruments;
                case Levels.Level5:
                    return ConfigurationUtils.FifthLevelInstruments;
                default:
                    return ConfigurationUtils.FirstLevelInstruments;
            }
        }
    }

    /// <summary>
    /// Gets the list of instruments in the code
    /// </summary>
    public static Dictionary<string, List<string>> numberOfInstrumentsList
    {
        get { 
            switch (levelSelected)
            {
                case Levels.Level1:
                    return ConfigurationUtils.FirstLevelInstrumentsList;
                case Levels.Level2:
                    return ConfigurationUtils.SecondLevelInstrumentsList;
                case Levels.Level3:
                    return ConfigurationUtils.ThirdLevelInstrumentsList;
                case Levels.Level4:
                    return ConfigurationUtils.FourthLevelInstrumentsList;
                case Levels.Level5:
                    return ConfigurationUtils.FifthLevelInstrumentsList;
                default:
                    return ConfigurationUtils.FirstLevelInstrumentsList;
            }
        }
    }

    /// <summary>
    /// Gets the number of notes in the code
    /// </summary>
    public static float numberOfNotes
    {
        get { 
            switch (levelSelected)
            {
                case Levels.Level1:
                    return ConfigurationUtils.FirstLevelNotes;
                case Levels.Level2:
                    return ConfigurationUtils.SecondLevelNotes;
                case Levels.Level3:
                    return ConfigurationUtils.ThirdLevelNotes;
                case Levels.Level4:
                    return ConfigurationUtils.FourthLevelNotes;
                case Levels.Level5:
                    return ConfigurationUtils.FifthLevelNotes;
                default:
                    return ConfigurationUtils.FirstLevelNotes;
            }
        }
    }

    /// <summary>
    /// Gets the list of notes in the code
    /// </summary>
    public static List<string> numberOfNotesList
    {
        get { 
            switch (levelSelected)
            {
                case Levels.Level1:
                    return ConfigurationUtils.FirstLevelNotesList;
                case Levels.Level2:
                    return ConfigurationUtils.SecondLevelNotesList;
                case Levels.Level3:
                    return ConfigurationUtils.ThirdLevelNotesList;
                case Levels.Level4:
                    return ConfigurationUtils.FourthLevelNotesList;
                case Levels.Level5:
                    return ConfigurationUtils.FifthLevelNotesList;
                default:
                    return ConfigurationUtils.FirstLevelNotesList;
            }
        }
    }

    /// <summary>
    /// Gets the number of DAW rows in the code
    /// </summary>
    public static float numberOfDAWRows
    {
        get { 
            switch (levelSelected)
            {
                case Levels.Level1:
                    return ConfigurationUtils.FirstLevelDAWRows;
                case Levels.Level2:
                    return ConfigurationUtils.SecondLevelDAWRows;
                case Levels.Level3:
                    return ConfigurationUtils.ThirdLevelDAWRows;
                case Levels.Level4:
                    return ConfigurationUtils.FourthLevelDAWRows;
                case Levels.Level5:
                    return ConfigurationUtils.FifthLevelDAWRows;
                default:
                    return ConfigurationUtils.FirstLevelDAWRows;
            }
        }
    }

    /// <summary>
    /// Gets the number of DAW containers in the code
    /// </summary>
    public static float numberOfDAWContainers
    {
        get { 
            switch (levelSelected)
            {
                case Levels.Level1:
                    return ConfigurationUtils.FirstLevelDAWContainers;
                case Levels.Level2:
                    return ConfigurationUtils.SecondLevelDAWContainers;
                case Levels.Level3:
                    return ConfigurationUtils.ThirdLevelDAWContainers;
                case Levels.Level4:
                    return ConfigurationUtils.FourthLevelDAWContainers;
                case Levels.Level5:
                    return ConfigurationUtils.FifthLevelDAWContainers;
                default:
                    return ConfigurationUtils.FirstLevelDAWContainers;
            }
        }
    }

    /// <summary>
    /// Gets the mission name in the code
    /// </summary>
    public static string missionName
    {
        get { 
            switch (levelSelected)
            {
                case Levels.Level1:
                    return ConfigurationUtils.FirstLevelMissionName;
                case Levels.Level2:
                    return ConfigurationUtils.SecondLevelMissionName;
                case Levels.Level3:
                    return ConfigurationUtils.ThirdLevelMissionName;
                case Levels.Level4:
                    return ConfigurationUtils.FourthLevelMissionName;
                case Levels.Level5:
                    return ConfigurationUtils.FifthLevelMissionName;
                default:
                    return ConfigurationUtils.FirstLevelMissionName;
            }
        }
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Initializes the level select utils
    /// </summary>
    public static void Initialize()
    {
        EventManager.AddGameStartedListener(HandleGameStartedEvent);
    }

    /// <summary>
    /// Sets the level selected
    /// </summary>
    /// <param name="level">level</param>
    static void HandleGameStartedEvent(Levels level)
    {
        levelSelected = level;
        SceneManager.LoadScene("Gameplay");
    }

    #endregion
}
