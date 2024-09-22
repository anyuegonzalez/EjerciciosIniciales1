using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] int experiencia;
    [SerializeField] int nivelPersonaje;
    void Start()
    {
        nivelPersonaje = 32 + (9 * experiencia / 5);
        Debug.Log("El nivel del personaje es el siguiente: " +  nivelPersonaje);
        
    }

    
    void Update()
    {
        
    }
}
