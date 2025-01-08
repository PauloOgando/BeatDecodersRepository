using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A container for configuration data
/// </summary>
public class ConfigurationData
{
    #region Fields

    // configuration data
    float firstLevelInstruments;
    Dictionary<string, List<string>> firstLevelInstrumentsList;
    float firstLevelNotes;
    List<string> firstLevelNotesList;
    float firstLevelDAWRows;
    float firstLevelDAWContainers;
    string firstLevelMissionName;
    float secondLevelInstruments;
    Dictionary<string, List<string>> secondLevelInstrumentsList;
    float secondLevelNotes;
    List<string> secondLevelNotesList;
    float secondLevelDAWRows;
    float secondLevelDAWContainers;
    string secondLevelMissionName;
    float thirdLevelInstruments;
    Dictionary<string, List<string>> thirdLevelInstrumentsList;
    float thirdLevelNotes;
    List<string> thirdLevelNotesList;
    float thirdLevelDAWRows;
    float thirdLevelDAWContainers;
    string thirdLevelMissionName;
    float fourthLevelInstruments;
    Dictionary<string, List<string>> fourthLevelInstrumentsList;
    float fourthLevelNotes;
    List<string> fourthLevelNotesList;
    float fourthLevelDAWRows;
    float fourthLevelDAWContainers;
    string fourthLevelMissionName;
    float fifthLevelInstruments;
    Dictionary<string, List<string>> fifthLevelInstrumentsList;
    float fifthLevelNotes;
    List<string> fifthLevelNotesList;
    float fifthLevelDAWRows;
    float fifthLevelDAWContainers;
    string fifthLevelMissionName;

    #endregion

    #region Properties

    public float FirstLevelInstruments
    {
        get { return firstLevelInstruments; }
    }

    public Dictionary<string, List<string>> FirstLevelInstrumentsList
    {
        get { return firstLevelInstrumentsList; }
    }

    public float FirstLevelNotes
    {
        get { return firstLevelNotes; }
    }

    public List<string> FirstLevelNotesList
    {
        get { return firstLevelNotesList; }
    }

    public float FirstLevelDAWRows
    {
        get { return firstLevelDAWRows; }
    }

    public float FirstLevelDAWContainers
    {
        get { return firstLevelDAWContainers; }
    }

    public string FirstLevelMissionName
    {
        get { return firstLevelMissionName; }
    }

    public float SecondLevelInstruments
    {
        get { return secondLevelInstruments; }
    }

    public Dictionary<string, List<string>> SecondLevelInstrumentsList
    {
        get { return secondLevelInstrumentsList; }
    }

    public float SecondLevelNotes
    {
        get { return secondLevelNotes; }
    }

    public List<string> SecondLevelNotesList
    {
        get { return secondLevelNotesList; }
    }

    public float SecondLevelDAWRows
    {
        get { return secondLevelDAWRows; }
    }

    public float SecondLevelDAWContainers
    {
        get { return secondLevelDAWContainers; }
    }

    public string SecondLevelMissionName
    {
        get { return secondLevelMissionName; }
    }

    public float ThirdLevelInstruments
    {
        get { return thirdLevelInstruments; }
    }

    public Dictionary<string, List<string>> ThirdLevelInstrumentsList
    {
        get { return thirdLevelInstrumentsList; }
    }

    public float ThirdLevelNotes
    {
        get { return thirdLevelNotes; }
    }

    public List<string> ThirdLevelNotesList
    {
        get { return thirdLevelNotesList; }
    }

    public float ThirdLevelDAWRows
    {
        get { return thirdLevelDAWRows; }
    }

    public float ThirdLevelDAWContainers
    {
        get { return thirdLevelDAWContainers; }
    }

    public string ThirdLevelMissionName
    {
        get { return thirdLevelMissionName; }
    }

    public float FourthLevelInstruments
    {
        get { return fourthLevelInstruments; }
    }

    public Dictionary<string, List<string>> FourthLevelInstrumentsList
    {
        get { return fourthLevelInstrumentsList; }
    }

    public float FourthLevelNotes
    {
        get { return fourthLevelNotes; }
    }

    public List<string> FourthLevelNotesList
    {
        get { return fourthLevelNotesList; }
    }

    public float FourthLevelDAWRows
    {
        get { return fourthLevelDAWRows; }
    }

    public float FourthLevelDAWContainers
    {
        get { return fourthLevelDAWContainers; }
    }

    public string FourthLevelMissionName
    {
        get { return fourthLevelMissionName; }
    }

    public float FifthLevelInstruments
    {
        get { return fifthLevelInstruments; }
    }

    public Dictionary<string, List<string>> FifthLevelInstrumentsList
    {
        get { return fifthLevelInstrumentsList; }
    }

    public float FifthLevelNotes
    {
        get { return fifthLevelNotes; }
    }

    public List<string> FifthLevelNotesList
    {
        get { return fifthLevelNotesList; }
    }

    public float FifthLevelDAWRows
    {
        get { return fifthLevelDAWRows; }
    }

    public float FifthLevelDAWContainers
    {
        get { return fifthLevelDAWContainers; }
    }

    public string FifthLevelMissionName
    {
        get { return fifthLevelMissionName; }
    }

    #endregion

    #region Constructor

    public ConfigurationData()
    {
        // read configuration data
        firstLevelInstruments = 2f;
        firstLevelInstrumentsList = new Dictionary<string, List<string>> { 
            { "Kick", new List<string> { "LongQuaver", "CrotchetRest", "LongQuaver", "CrotchetRest" } }, 
            { "Snare", new List<string> { "CrotchetRest", "Crotchet", "CrotchetRest", "Crotchet" } } };
        firstLevelNotes = 3f;
        firstLevelNotesList = new List<string> { "Crotchet", "CrotchetRest", "LongQuaver" };
        firstLevelDAWRows = 2f;
        firstLevelDAWContainers = 4f;
        firstLevelMissionName = "Gate";
        secondLevelInstruments = 3f;
        secondLevelInstrumentsList = new Dictionary<string, List<string>> { 
            { "Kick", new List<string> { "Crotchet", "CrotchetRest", "Crotchet", "CrotchetRest" } }, 
            { "Snare", new List<string> { "CrotchetRest", "Crotchet", "CrotchetRest", "Crotchet" } }, 
            { "ClosedHiHat", new List<string> { "LongSemiQuaver", "LongSemiQuaver", "LongSemiQuaver", "LongSemiQuaver" } } };
        secondLevelNotes = 3f;
        secondLevelNotesList = new List<string> { "Crotchet", "CrotchetRest", "LongSemiQuaver" };
        secondLevelDAWRows = 3f;
        secondLevelDAWContainers = 4f;
        secondLevelMissionName = "Front Door";
        thirdLevelInstruments = 3f;
        thirdLevelInstrumentsList = new Dictionary<string, List<string>> { 
            { "Kick", new List<string> { "LongQuaver", "QuaverRest", "Quaver", "Minim" } }, 
            { "Snare", new List<string> { "CrotchetRest", "Crotchet", "CrotchetRest", "Crotchet" } }, 
            { "Ride", new List<string> { "Crotchet", "Crotchet", "Crotchet", "Crotchet" } } };
        thirdLevelNotes = 6f;
        thirdLevelNotesList = new List<string> { "Minim", "Crotchet", "Quaver", "LongQuaver", "CrotchetRest", "QuaverRest" };
        thirdLevelDAWRows = 3f;
        thirdLevelDAWContainers = 4f;
        thirdLevelMissionName = "MusicBot";
        fourthLevelInstruments = 4f;
        fourthLevelInstrumentsList = new Dictionary<string, List<string>> { 
            { "Kick", new List<string> { "Crotchet", "Crotchet", "Crotchet", "Crotchet", "Crotchet", "Crotchet", "Crotchet", "Crotchet" } }, 
            { "Snare", new List<string> { "CrotchetRest", "Crotchet", "CrotchetRest", "Crotchet",  "CrotchetRest", "Crotchet", "CrotchetRest", "Crotchet"} }, 
            { "Clap", new List<string> { "MinimRest", "QuaverRest", "SemiQuaverRest", "SemiQuaver", "QuaverRest", "Quaver" } }, 
            { "ClosedHiHat", new List<string> { "QuaverRest", "Quaver", "QuaverRest", "Quaver", "QuaverRest", "InverseLongSemiQuaver", "QuaverRest", "InverseLongSemiQuaver", "QuaverRest",  "Quaver", "QuaverRest", "Quaver", "QuaverRest", "Quaver", "QuaverRest", "InverseLongSemiQuaver"} } };
        fourthLevelNotes = 9f;
        fourthLevelNotesList = new List<string> { "Crotchet", "Quaver", "SemiQuaver", "MinimRest", "InverseLongSemiQuaver", "CrotchetRest", "QuaverRest", "SemiQuaverRest", "SemiBreveRest"};
        fourthLevelDAWRows = 4f;
        fourthLevelDAWContainers = 8f;
        fourthLevelMissionName = "Vault";
        fifthLevelInstruments = 5f;
        fifthLevelInstrumentsList = new Dictionary<string, List<string>> { 
            { "Kick", new List<string> { "Crotchet", "CrotchetRest", "QuaverRest", "Quaver", "SemiQuaverRest", "SemiQuaver", "Quaver", "Crotchet", "CrotchetRest", "CrotchetRest", "CrotchetRest"} }, 
            { "Snare", new List<string> { "CrotchetRest", "CrotchetRest", "Crotchet", "CrotchetRest", "CrotchetRest", "CrotchetRest", "Crotchet", "CrotchetRest" } }, 
            { "Clap", new List<string> { "SemiBreveRest", "CrotchetRest", "CrotchetRest", "CrotchetRest", "QuaverRest", "Quaver" } }, 
            { "ClosedHiHat", new List<string> { "LongSemiQuaver", "LongQuaver", "LongSemiQuaver", "LongSemiQuaver", "LongQuaver", "QuaverRest", "LongSemiQuaver" } }, 
            { "OpenHiHat", new List<string> { "SemiBreveRest", "CrotchetRest", "CrotchetRest", "CrotchetRest", "Crotchet"} } };
        fifthLevelNotes = 10f;
        fifthLevelNotesList = new List<string> { "Crotchet", "Quaver", "SemiQuaver", "LongQuaver", "InverseLongSemiQuaver", "LongSemiQuaver", "CrotchetRest", "QuaverRest", "SemiQuaverRest", "SemiBreveRest" };
        fifthLevelDAWRows = 5f;
        fifthLevelDAWContainers = 8f;
        fifthLevelMissionName = "Music Beast";
    }

    #endregion
}
