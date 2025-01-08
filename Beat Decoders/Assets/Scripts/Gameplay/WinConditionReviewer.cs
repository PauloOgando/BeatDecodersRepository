using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Linq;

public class WinConditionReviewer : MonoBehaviour
{
    [SerializeField] GameObject notesContainer;

    List<string> userNotes = new List<string>();
    List<string> correctNotes = new List<string>();

    LifeLostEvent lifeLostEvent = new LifeLostEvent();

    // Start is called before the first frame update
    void Start()
    {
        AudioManager.Stop(AudioClipName.BeatDecodersMenu);
        EventManager.AddLifeLostInvoker(this);
        EventManager.AddLastLifeLostListener(HandleLastLifeLost);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale != 0)
        {
            MenuManager.GoToMenu(MenuName.Pause);
        }
    }

    public void ReviewWinCondition()
    {
        // Limpia las listas antes de cada ejecución
        userNotes.Clear();
        correctNotes.Clear();

        // Construir la lista de notas correctas
        foreach (var keyValue in ConfigurationUtils.listOfInstruments)
        {
            foreach (var note in keyValue.Value)
            {
                correctNotes.Add(note);
            }
        }

        // Construir la lista de notas del usuario desde la jerarquía
        foreach (Transform notesRow in notesContainer.transform)
        {
            foreach (Transform noteContainer in notesRow)
            {
                if (noteContainer.childCount > 0)
                {
                    var musicalNote = noteContainer.GetChild(0).GetComponent<MusicalNote>();
                    if (musicalNote != null)
                    {
                        userNotes.Add(musicalNote.NoteName);
                    }
                    else
                    {
                        Debug.LogWarning("El objeto en noteContainer no tiene el componente MusicalNote.");
                    }
                }
                else
                {
                    userNotes.Add("Empty");
                }
            }
        }

        // Comparar notas correctas con notas del usuario
        int userNoteIndex = 0;
        foreach (Transform notesRow in notesContainer.transform)
        {
            foreach (Transform noteContainer in notesRow)
            {
                if (userNoteIndex >= correctNotes.Count)
                {
                    Debug.LogWarning("La cantidad de notas en correctNotes no coincide con la jerarquía de notesContainer.");
                    return;
                }

                if (correctNotes[userNoteIndex] != userNotes[userNoteIndex])
                {
                    Debug.Log($"Correct note: {correctNotes[userNoteIndex]} | User note: {userNotes[userNoteIndex]}");

                    // Elimina el objeto de la jerarquía si existe
                    if (noteContainer.childCount > 0)
                    {
                        var noteObject = noteContainer.GetChild(0).gameObject;
                        Destroy(noteObject);
                        lifeLostEvent.Invoke();
                    }

                    return;
                }

                userNoteIndex++;
            }
        }
        // Si todas las notas son correctas, se gana el nivel
        GameObject missionAccomplishedMessage = Instantiate(Resources.Load("MissionAccomplishedMessage") as GameObject);
    }

    /// <summary>
    /// Ends the game if the last life is lost
    /// </summary>
    void HandleLastLifeLost()
    {
        GameObject gameOverMessage = Instantiate(Resources.Load("GameOverMessage") as GameObject);
    }

    /// <summary>
    /// Adds the given method as a life lost listener
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddLifeLostListener(UnityAction listener)
    {
        lifeLostEvent.AddListener(listener);
    }
}
