using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchScript : MonoBehaviour
{
    [SerializeField]
    private GameObject item;

    [SerializeField]
    private

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(item);
        }
    }
}
