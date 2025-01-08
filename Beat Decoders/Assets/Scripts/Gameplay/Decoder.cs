using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Decoder : MonoBehaviour
{

    [SerializeField]
    GameObject correspondingNotePrefab;

    [SerializeField]
    GameObject notesColumnContainer;
    [SerializeField] GameObject imageColumnContainer;

    void Start()
    {
        PopulateDecoder();
    }

    void Update()
    {
        // if the notes column has changed, update the decoder
        if (ConfigurationUtils.listOfNotes.Count != notesColumnContainer.transform.childCount)
        {
            PopulateDecoder();
        }

    }

    /// <summary>
    /// Populates the decoder with the notes
    /// </summary>
    public void PopulateDecoder()
    {
        /// Clear the notes column
        foreach (Transform child in notesColumnContainer.transform)
        {
            Destroy(child.gameObject);
        }
        /// Clear the image column
        foreach (Transform child in imageColumnContainer.transform)
        {
            Destroy(child.gameObject);
        }
        foreach(string note in ConfigurationUtils.listOfNotes)
        {
            switch (note)
            {
                case "Crotchet":
                    CreateNote("Crotchet", 1, 3);
                    CreateImage("Crotchet");
                    break;
                case "CrotchetRest":
                    CreateNote("CrotchetRest", 0, 4);
                    CreateImage("CrotchetRest");
                    break;
                case "LongQuaver":
                    GameObject Note3 = Instantiate(correspondingNotePrefab, Vector3.zero, Quaternion.identity) as GameObject;
                    Note3.GetComponent<MusicalNote>().CreateLongQuaver();
                    Note3.GetComponent<MusicalNote>().NoteName = "LongQuaver";
                    Note3.transform.SetParent(notesColumnContainer.transform);
                    CreateImage("LongQuaver");
                    break;
                case "LongSemiQuaver":
                    CreateNote("LongSemiQuaver", 4, 0);
                    CreateImage("LongSemiQuaver");
                    break;
                case "Minim":
                    CreateNote("Minim", 1, 7);
                    CreateImage("Minim");
                    break;
                case "Quaver":
                    CreateNote("Quaver", 1, 1);
                    CreateImage("Quaver");
                    break;
                case "QuaverRest":
                    CreateNote("QuaverRest", 0, 2);
                    CreateImage("QuaverRest");
                    break;
                case "SemiQuaver":
                    CreateNote("SemiQuaver", 1, 0);
                    CreateImage("SemiQuaver");
                    break;
                case "SemiBreveRest":
                    CreateNote("SemiBreveRest", 0, 16);
                    CreateImage("SemiBreveRest");
                    break;
                case "MinimRest":
                    CreateNote("MinimRest", 0, 8);
                    CreateImage("MinimRest");
                    break;
                case "InverseLongSemiQuaver":
                    CreateNote("InverseLongSemiQuaver", 2, 0);
                    CreateImage("InverseLongSemiQuaver");
                    break;
                case "SemiQuaverRest":
                    CreateNote("SemiQuaverRest", 0, 1);
                    CreateImage("SemiQuaverRest");
                    break;
            }
        }
    }

    void CreateNote(string notename, int fullSquares, int emptySquares)
    {
        GameObject Note = Instantiate(correspondingNotePrefab, Vector3.zero, Quaternion.identity) as GameObject;
        Note.GetComponent<MusicalNote>().AddSquares(fullSquares, emptySquares);
        Note.GetComponent<MusicalNote>().NoteName = notename;
        Note.transform.SetParent(notesColumnContainer.transform);
    }

    void CreateImage(string note)
    {
        GameObject noteImage = new GameObject(note);
        noteImage.transform.SetParent(imageColumnContainer.transform);
        Image image = noteImage.AddComponent<Image>();
        image.sprite = Camera.main.GetComponent<NoteSpritesDictionary>().GetSprite(note);
        image.rectTransform.sizeDelta = new Vector2(50, 50);
    }

    
    
}
