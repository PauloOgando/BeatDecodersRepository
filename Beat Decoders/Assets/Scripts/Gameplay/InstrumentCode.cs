using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstrumentCode : MonoBehaviour
{
    // List of every instrument sprite
    [SerializeField] Sprite kickSprite;
    [SerializeField] Sprite snareSprite;
    [SerializeField] Sprite rideSprite;
    [SerializeField] Sprite closedhiHatSprite;
    [SerializeField] Sprite openhiHatSprite;
    [SerializeField] Sprite clapSprite;
    [SerializeField] Dictionary<string, Sprite> instrumentSprites;

    [SerializeField] GameObject instrumentImageGameObject;
    [SerializeField] GameObject notesContainer;


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

    public void AssignInstrument(string instrument)
    {
        instrumentImageGameObject.GetComponent<Image>().sprite = instrumentSprites[instrument];
    }

    public void AddNote(string noteSprite)
    {
        GameObject note = new GameObject("Note");
        note.AddComponent<RectTransform>();
        /// Set width to 50
        note.GetComponent<RectTransform>().sizeDelta = new Vector2(50, 50);
        note.AddComponent<Image>();
        note.GetComponent<Image>().sprite = Camera.main.GetComponent<NoteSpritesDictionary>().GetSprite(noteSprite);
        note.transform.SetParent(notesContainer.transform);
    }
}
