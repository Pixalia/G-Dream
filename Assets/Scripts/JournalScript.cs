using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JournalScript : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    public Image book;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        book.enabled = false;
    }
}
