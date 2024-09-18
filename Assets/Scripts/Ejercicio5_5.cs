using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    [SerializeField] int numero;
    void Start()
    {
        if(numero < 0 &&  numero > 9)
        {
            Debug.Log("Este numero está entre los numeros 0 y 9; " +  numero);
        }
    }


    void Update()
    {
        
    }
}
