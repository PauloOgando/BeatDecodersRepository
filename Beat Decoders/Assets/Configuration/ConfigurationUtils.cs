using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides access to configuration data
/// </summary>
public static class ConfigurationUtils
{
    #region Fields

    static ConfigurationData configurationData;

    #endregion

    #region Properties

    public static float numberOfInstruments
    {
        get { return LevelSelectUtils.numberOfInstruments; }
    }

    public static Dictionary<string, List<string>> listOfInstruments
    {
        get { return LevelSelectUtils.numberOfInstrumentsList; }
    }

    public static float numberOfNotes
    {
        get { return LevelSelectUtils.numberOfNotes; }
    }

    public static List<string> listOfNotes
    {
        get { return LevelSelectUtils.numberOfNotesList; }
    }

    public static float numberOfDAWRows
    {
        get { return LevelSelectUtils.numberOfDAWRows; }
    }

    public static float numberOfDAWContainers
    {
        get { return LevelSelectUtils.numberOfDAWContainers; }
    }

    public static string missionName
    {
        get { return LevelSelectUtils.missionName; }
    }

    #endregion

    #region Properties for LevelSelectUtils

    public static float FirstLevelInstruments
    {
        get { return configurationData.FirstLevelInstruments; }
    }

    public static Dictionary<string, List<string>> FirstLevelInstrumentsList
    {
        get { return configurationData.FirstLevelInstrumentsList; }
    }

    public static float FirstLevelNotes
    {
        get { return configurationData.FirstLevelNotes; }
    }

    public static List<string> FirstLevelNotesList
    {
        get { return configurationData.FirstLevelNotesList; }
    }

    public static float FirstLevelDAWRows
    {
        get { return configurationData.FirstLevelDAWRows; }
    }

    public static float FirstLevelDAWContainers
    {
        get { return configurationData.FirstLevelDAWContainers; }
    }

    public static string FirstLevelMissionName
    {
        get { return configurationData.FirstLevelMissionName; }
    }

    public static float SecondLevelInstruments
    {
        get { return configurationData.SecondLevelInstruments; }
    }

    public static Dictionary<string, List<string>> SecondLevelInstrumentsList
    {
        get { return configurationData.SecondLevelInstrumentsList; }
    }

    public static float SecondLevelNotes
    {
        get { return configurationData.SecondLevelNotes; }
    }

    public static List<string> SecondLevelNotesList
    {
        get { return configurationData.SecondLevelNotesList; }
    }    

    public static float SecondLevelDAWRows
    {
        get { return configurationData.SecondLevelDAWRows; }
    }

    public static float SecondLevelDAWContainers
    {
        get { return configurationData.SecondLevelDAWContainers; }
    }

    public static string SecondLevelMissionName
    {
        get { return configurationData.SecondLevelMissionName; }
    }

    public static float ThirdLevelInstruments
    {
        get { return configurationData.ThirdLevelInstruments; }
    }

    public static Dictionary<string, List<string>> ThirdLevelInstrumentsList
    {
        get { return configurationData.ThirdLevelInstrumentsList; }
    }

    public static float ThirdLevelNotes
    {
        get { return configurationData.ThirdLevelNotes; }
    }

    public static List<string> ThirdLevelNotesList
    {
        get { return configurationData.ThirdLevelNotesList; }
    }

    public static float ThirdLevelDAWRows
    {
        get { return configurationData.ThirdLevelDAWRows; }
    }

    public static float ThirdLevelDAWContainers
    {
        get { return configurationData.ThirdLevelDAWContainers; }
    }

    public static string ThirdLevelMissionName
    {
        get { return configurationData.ThirdLevelMissionName; }
    }

    public static float FourthLevelInstruments
    {
        get { return configurationData.FourthLevelInstruments; }
    }

    public static Dictionary<string, List<string>> FourthLevelInstrumentsList
    {
        get { return configurationData.FourthLevelInstrumentsList; }
    }

    public static float FourthLevelNotes
    {
        get { return configurationData.FourthLevelNotes; }
    }

    public static List<string> FourthLevelNotesList
    {
        get { return configurationData.FourthLevelNotesList; }
    }

    public static float FourthLevelDAWRows
    {
        get { return configurationData.FourthLevelDAWRows; }
    }

    public static float FourthLevelDAWContainers
    {
        get { return configurationData.FourthLevelDAWContainers; }
    }

    public static string FourthLevelMissionName
    {
        get { return configurationData.FourthLevelMissionName; }
    }

    public static float FifthLevelInstruments
    {
        get { return configurationData.FifthLevelInstruments; }
    }

    public static Dictionary<string, List<string>> FifthLevelInstrumentsList
    {
        get { return configurationData.FifthLevelInstrumentsList; }
    }

    public static float FifthLevelNotes
    {
        get { return configurationData.FifthLevelNotes; }
    }

    public static List<string> FifthLevelNotesList
    {
        get { return configurationData.FifthLevelNotesList; }
    }

    public static float FifthLevelDAWRows
    {
        get { return configurationData.FifthLevelDAWRows; }
    }

    public static float FifthLevelDAWContainers
    {
        get { return configurationData.FifthLevelDAWContainers; }
    }

    public static string FifthLevelMissionName
    {
        get { return configurationData.FifthLevelMissionName; }
    }

    #endregion
    
    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
        configurationData = new ConfigurationData();
    }
}
