using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
   
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    void Start()
    {
        if (numero1 < 3 && numero2 < 3)
        {
            Debug.Log("Ambos numeros son menores a 3 ");
        }

    }


    void Update()
    {
        
    }
}
