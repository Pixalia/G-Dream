using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JournalScript : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    public Image book;

    void Start()
    {
        book.enabled = false;
    }

    void Update()
    {
        if (book.enabled == true)
        {
            Time.timeScale = 0;
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        book.enabled = false;
        Time.timeScale = 1;
    }
}
