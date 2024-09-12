using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    public int vidas = 5;
    public float exp = 5;
    public int resultadoSuma, resultadoResta;
    //char = 'c';
    void Start()
    {

        vidas += 5;
        resultadoSuma = vidas;

        vidas -= 5;
        resultadoResta = vidas;
    }

    
    void Update()
    {
        
    }
}