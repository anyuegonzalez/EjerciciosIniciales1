using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    [SerializeField] float areaCirculo;
    [SerializeField] float areaCuadrado;
    [SerializeField] float areaTriangulo;
    [SerializeField] int circulo, triangulo, cuadrado;
    private float radioAlCuadrado,baseT = 17.8f,altura = 26.2f,lado,pi = 3.141592f;
    void Start()
    {
        AreaCirculo();
        Debug.Log("El area del circulo es: " + areaCirculo);
        AreaTriangulo();
        Debug.Log("El area del Triangulo es: " + areaTriangulo);
    }

    
    void Update()
    {
        
    }
    void AreaCirculo()
    {
        areaCirculo = pi * radioAlCuadrado;
    }
    void AreaTriangulo()
    {

    }
}
