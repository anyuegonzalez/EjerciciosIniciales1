using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{
    // declarar variables
    int vida = 50; // el tipo (int, float...) solo lo pones una vez
    float porcentajeAcierto; // por defecto es un 0.0f
    bool quemado;// por defecto es false
    string explorador; // por defecto es ""
    char solucionPuzzle; // por defecto es ''

    // 

    void Start()
    {
        
        Debug.Log("Hello world");
        Debug.Log("Este es el primer videojuego de Anyué");
        Debug.Log("Estoy aprendiendo C#");
        
        //vida = 7; // asignar un valor a la variable.
    }

    
    void Update()
    {
        Debug.Log("ha pasado un frame"); // aparece tantas veces debidoa que se repite porque se actualiza por frame
    }
}
