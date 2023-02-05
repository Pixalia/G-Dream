using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchScript : MonoBehaviour
{

    public BarScript matchstick;

    [SerializeField]
    private GameObject item;


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            matchstick.RefillGas();
            Destroy(item);
        }
    }
}
