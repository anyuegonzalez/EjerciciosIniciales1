using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    
    void Start()
    {
        ConstruirNombre("Anyué ", "González", "Benito", 19);
        //Debug.Log();
    }

    
    void Update()
    {
        
    }
    string ConstruirNombre(string nombre, string apellido1, string apellido2, int edad)
    {
        return "La persona se llama " + nombre + " " + apellido1 + " " + apellido2 + " " + edad + ".";
    }
}
