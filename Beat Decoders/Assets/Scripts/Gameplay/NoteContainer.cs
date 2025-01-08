using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NoteContainer : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if(transform.childCount == 1)
        {
            return;
        }
        GameObject droppedObject = eventData.pointerDrag;
        DraggableItem draggableItem = droppedObject.GetComponent<DraggableItem>();
        draggableItem.parentAfterDrag = transform;
    }
}
