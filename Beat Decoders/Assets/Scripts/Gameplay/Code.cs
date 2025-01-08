using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    [SerializeField]
    GameObject instrumentRhytmPrefab;
    [SerializeField]
    GameObject codeSectionGameObject;

    void Start()
    {
        PopulateCodeSection();
    }

    /// <summary>
    /// Populates the code section with the instruments
    /// </summary>
    void PopulateCodeSection()
    {
        foreach(var keyvalue in ConfigurationUtils.listOfInstruments)
        {
            switch (keyvalue.Key)
            {
                case "Kick":
                    CreateInstrument("Kick", keyvalue.Value);
                    break;
                case "Snare":
                    CreateInstrument("Snare", keyvalue.Value);
                    break;
                case "Ride":
                    CreateInstrument("Ride", keyvalue.Value);
                    break;
                case "ClosedHiHat":
                    CreateInstrument("ClosedHiHat", keyvalue.Value);
                    break;
                case "OpenHiHat":
                    CreateInstrument("OpenHiHat", keyvalue.Value);
                    break;
                case "Clap":
                    CreateInstrument("Clap", keyvalue.Value);
                    break;
            }
        }
    }

    void CreateInstrument(string instrument, List<string> notes)
    {
        GameObject Instrument = Instantiate(instrumentRhytmPrefab, Vector3.zero, Quaternion.identity) as GameObject;
        Instrument.GetComponent<InstrumentCode>().AssignInstrument(instrument);
        foreach (var note in notes)
        {
            Instrument.GetComponent<InstrumentCode>().AddNote(note);
        }
        Instrument.transform.SetParent(codeSectionGameObject.transform);
    }
}
