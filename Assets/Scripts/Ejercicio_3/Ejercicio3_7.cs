using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] float baseTriangulo;
    [SerializeField] float alturaTriangulo;
    [SerializeField] float areaTriangulo;

    //para calcular el area se usara la formula matematica: base por altura partido por 2.

    void Start()
    {
        areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
        Debug.Log("El area del triangulo es la siguiente: " +  areaTriangulo);

    }

    
    void Update()
    {
        
    }
}
