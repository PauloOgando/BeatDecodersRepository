using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Daw : MonoBehaviour
{
    [SerializeField] Sprite kickSprite;
    [SerializeField] Sprite snareSprite;
    [SerializeField] Sprite rideSprite;
    [SerializeField] Sprite closedhiHatSprite;
    [SerializeField] Sprite openhiHatSprite;
    [SerializeField] Sprite clapSprite;
    [SerializeField] Dictionary<string, Sprite> instrumentSprites;
    [SerializeField] GameObject notesRowPrefab;
    [SerializeField] GameObject noteContainerPrefab;
    [SerializeField] GameObject imageColumnGameObject;
    [SerializeField] GameObject notesColumnGameObject;

    void Awake()
    {
        instrumentSprites = new Dictionary<string, Sprite>{
            {"Kick", kickSprite},
            {"Snare", snareSprite},
            {"Ride", rideSprite},
            {"ClosedHiHat", closedhiHatSprite},
            {"OpenHiHat", openhiHatSprite},
            {"Clap", clapSprite}
        };
    }

    void Start()
    {
        PopulateDAW();
        CreateImages();
    }

    void PopulateDAW()
    {
        // Clear the DAW
        foreach (Transform child in notesColumnGameObject.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in imageColumnGameObject.transform)
        {
            Destroy(child.gameObject);
        }

        foreach(var keyvalue in ConfigurationUtils.listOfInstruments)
        {
            GameObject notesRow = Instantiate(notesRowPrefab, Vector3.zero, Quaternion.identity) as GameObject;
            notesRow.transform.SetParent(notesColumnGameObject.transform);
            foreach(var note in keyvalue.Value)
            {
                GameObject noteContainer = Instantiate(noteContainerPrefab, Vector3.zero, Quaternion.identity) as GameObject;
                noteContainer.transform.SetParent(notesRow.transform);
            }
        }
    }

    void CreateImages()
    {
        foreach (var keyvalue in ConfigurationUtils.listOfInstruments)
        {
            switch (keyvalue.Key)
            {
                case "Kick":
                    CreateImage("Kick", keyvalue.Value);
                    break;
                case "Snare":
                    CreateImage("Snare", keyvalue.Value);
                    break;
                case "Ride":
                    CreateImage("Ride", keyvalue.Value);
                    break;
                case "ClosedHiHat":
                    CreateImage("ClosedHiHat", keyvalue.Value);
                    break;
                case "OpenHiHat":
                    CreateImage("OpenHiHat", keyvalue.Value);
                    break;
                case "Clap":
                    CreateImage("Clap", keyvalue.Value);
                    break;
            }
        }
    }

    void CreateImage(string instrument, List<string> notes)
    {
        GameObject instrumentImageGameObject = new GameObject("InstrumentImage");
        instrumentImageGameObject.AddComponent<RectTransform>();
        instrumentImageGameObject.AddComponent<Image>();
        instrumentImageGameObject.GetComponent<Image>().sprite = instrumentSprites[instrument];
        instrumentImageGameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(50, 50);
        instrumentImageGameObject.transform.SetParent(imageColumnGameObject.transform);
    }

}
