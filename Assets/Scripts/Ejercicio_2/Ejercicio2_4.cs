using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    [SerializeField] int vidas = 6;
    [SerializeField] int resultadoVidas;
    void Start()
    {
        vidas = 6;

        vidas = 6 + 77;
        resultadoVidas = vidas - 3;
        resultadoVidas = vidas * 4;
    }

  
    void Update()
    {
        
    }
}
