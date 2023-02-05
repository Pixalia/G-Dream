using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchController : MonoBehaviour
{

    [SerializeField]
    UnityEngine.Rendering.Universal.Light2D torchLight;

    public float torchGas;

    [SerializeField]
    private GameObject match;

    void Start()
    {
        torchLight.enabled = false;
        torchGas = 1.00f;
        torchLight.pointLightOuterRadius = 4;
        torchLight.falloffIntensity = 0.4f;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && !(torchLight.enabled))
        {
            torchLight.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.K) && torchLight.enabled)
        {
            torchLight.enabled = false;
        }
        if (match == null)
        {
            torchGas = 1.00f;
        }
    }

    void FixedUpdate()
    {
        if (torchLight.enabled)
        {
            torchGas -= .000003f;
            torchLight.pointLightOuterRadius *= torchGas;
        }
    }



}
