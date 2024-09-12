using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{

    public int vidas = 5, resultado;
    public float exp= 3, resultado1;
    void Start()
    {
        resultado = vidas * 3;
        resultado = vidas / 3;
        resultado = vidas * 2;
        resultado1 = exp * 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
