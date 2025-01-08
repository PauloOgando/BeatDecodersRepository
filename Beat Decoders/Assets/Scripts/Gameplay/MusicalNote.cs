using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicalNote : MonoBehaviour
{
    #region Fields
    [SerializeField] GameObject fullSquarePrefab;
    [SerializeField] GameObject emptySquarePrefab;


    int fullSquares;
    int emptySquares;
    int length;
    string noteName = "Empty";
    string noteSound = "None";

    #endregion

    #region Properties

    public string NoteName
    {
        set { noteName = value; }
        get { return noteName; }
    }

    public string NoteSound
    {
        set { noteSound = value; }
        get { return noteSound; }
    }

    #endregion
    
    /// <summary>
    /// Adds the squares to the note
    /// </summary>
    public void AddSquares(int fullSquares, int emptySquares)
    {
        this.fullSquares = fullSquares;
        this.emptySquares = emptySquares;
        length = fullSquares;

        for (int i = 0; i < fullSquares; i++)
        {
            Instantiate(fullSquarePrefab, transform);
        }

        for (int i = 0; i < emptySquares; i++)
        {
            Instantiate(emptySquarePrefab, transform);
        }
    }

    /// <summary>
    /// Creates a quaver note
    /// </summary>
    public void CreateLongQuaver()
    {
        fullSquares = 2;
        emptySquares = 2;
        length = 2;
        Instantiate(fullSquarePrefab, transform);
        Instantiate(emptySquarePrefab, transform);
        Instantiate(fullSquarePrefab, transform);
        Instantiate(emptySquarePrefab, transform);
    }
}
