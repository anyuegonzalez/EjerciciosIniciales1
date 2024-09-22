using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    [SerializeField] int vidaNumero1;
    [SerializeField] int vidaNumero2;
    void Start()
    {
        if (vidaNumero1 == vidaNumero2)
        {
            Debug.Log("La batalla esta reñida, ambos personajes tienen la misma cantidad de vida");
        }
    }

    void Update()
    {
        
    }
}
