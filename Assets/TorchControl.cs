using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchControl : MonoBehaviour
{

    [SerializeField]
    UnityEngine.Rendering.Universal.Light2D torchLight;

    public float torchGas;

    void Start()
    {
        torchLight.enabled = false;
        torchGas = 1.00f;
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

    }

    void FixedUpdate()
    {
        if (torchLight.enabled)
        {
            torchGas -= .000003f;
            torchLight.pointLightOuterRadius *= torchGas;
        }
    }*/
}
