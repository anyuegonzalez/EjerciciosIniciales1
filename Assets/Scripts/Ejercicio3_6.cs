using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float velocidadKMH;
    [SerializeField] float velocidadMS;

    void Start()
    {
        // 1 km = 1000m, 1h es 3600s
        velocidadMS = velocidadKMH * 1000 / 3600;
        Debug.Log("La velocidad convertida de KM/H en M/S es de: " +  velocidadMS);
    }

    
    void Update()
    {
        
    }
}
