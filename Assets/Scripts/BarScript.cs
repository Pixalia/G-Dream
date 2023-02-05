using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour
{
    public int torchGasAmount;
    public Slider torchGas;

    public void RefillGas()
    {
        torchGas.value = 2500;
        torchGasAmount = 2500;
    }

    public void reduceGas()
    {
        torchGasAmount -= 1;
        torchGas.value = torchGasAmount;
    }

    // Start is called before the first frame update
    void Start()
    {
        torchGas.maxValue = 2500;
        torchGas.minValue = 500;
        RefillGas();
    }
}
