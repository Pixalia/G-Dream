using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TorchController : MonoBehaviour
{

    [SerializeField]
    UnityEngine.Rendering.Universal.Light2D torchLight;
    
    public BarScript match;

    [SerializeField]
    private GameObject fireSprite;

    void Start()
    {
        torchLight.enabled = true;
        torchLight.pointLightOuterRadius = 4;
        torchLight.falloffIntensity = 0.4f;
    }


    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && !(torchLight.enabled))
        {
            torchLight.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.K) && torchLight.enabled)
        {
            torchLight.enabled = false;
        }
    }*/

    void FixedUpdate()
    {
        if (torchLight.enabled)
        {
            match.reduceGas();
            torchLight.pointLightOuterRadius = 4 * (match.torchGasAmount / 2500f);
        }
        if (match.torchGasAmount <= 500) 
        {
            fireSprite.SetActive(false);
        }
        else if (match.torchGasAmount > 500)
        {
            fireSprite.SetActive(true);
        }
    }


}
