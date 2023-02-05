using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButterflyScript : MonoBehaviour
{
    [SerializeField]
    public Image book;

    [SerializeField]
    private GameObject item;


    // Start is called before the first frame update
    void Start()
    {
        book.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            book.enabled = true;
            Destroy(item);
        }
    }

    /*void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            book.enabled = false;
        }
    }*/

    
}
