using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] float numerador;
    [SerializeField] float divisor;
    [SerializeField] float resultado;
    void Start()
    {
        if ( divisor != 0)
        {
            resultado = numerador / divisor; // para hacer la division.
            Debug.Log("El resultado de la division es; " +  resultado);
        }
    }


    void Update()
    {
        
    }
}
