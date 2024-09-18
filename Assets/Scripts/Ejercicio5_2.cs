using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int nivel;
    void Start()
    {

        if(nivel == 10)
        {
            Debug.Log("El pokemon ha alcanzado un nivel multiplo de 10 y aprende un nuevo ataque");
        }
    }

    
    void Update()
    {
        
    }
}
