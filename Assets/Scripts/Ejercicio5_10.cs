using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    [SerializeField] int temperatura;
    void Start()
    {
        if (temperatura <= 10)
        {
            Debug.Log("El clima de la temperatura es Clima Frio");
        }
        else if (10 < temperatura && temperatura <= 20)
        {
            Debug.Log("El clima de la temperatura es Clima Nublado");
        }
        else if (20 < temperatura && temperatura <= 30)
        {
            Debug.Log("El clima de la temperatura es clima Caluroso");
        }
        else if (temperatura > 30)
        {
            Debug.Log("El clima de la temperatura es clima Tropical");
        }
        
    }

   
    void Update()
    {
        
    }
}
