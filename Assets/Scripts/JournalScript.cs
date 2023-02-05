using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JournalScript : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    public Image book;

    [SerializeField]
    private GameObject entryOne;

    [SerializeField]
    private GameObject entryTwo;

    void Start()
    {
        book.enabled = false;
        entryOne.SetActive(true);
        entryTwo.SetActive(true);
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
        entryOne.SetActive(false); 
        entryTwo.SetActive(false);
        Time.timeScale = 1;
    }
}
