using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    // no se como hacer que el programa me de 3 horas aleatorias
    [SerializeField] int horas;
    [SerializeField] int minutos;
    [SerializeField] int segundos;
    void Start()
    {
        if ((horas >= 0 && horas < 24) && (minutos >= 0 && minutos < 60) && (segundos >= 0 && segundos < 3600))
        {
            Debug.Log("La hora es válida: ");
        }
        else 
        {
            Debug.Log("La hora es inválida");
        }
    }

   
    void Update()
    {
        
    }
    void CrearNumero()
    {

    }
}
