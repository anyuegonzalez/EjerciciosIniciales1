using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    [SerializeField] float baseTriangulo = 5f;
    [SerializeField] float radio = 6f;
    [SerializeField] float alturaTriangulo = 6f;
    [SerializeField] float areaTriangulo, areaCuadrdado, areaCirculo;
    [SerializeField] float ladoCuadrado = 3f;
    void Start()
    {
        CalcularAreaCirculo();
        CalcularAreaCuadrado();
        CalcularAreaTriangulo();

        Debug.Log("El area del triangulo es: " + areaTriangulo);
        Debug.Log("El area del circulo es: " + areaCirculo);
        Debug.Log("El area del cuadrado es: " + areaCuadrdado);
    }
    void Update()
    {
        
    }
    void CalcularAreaTriangulo()
    {
        areaTriangulo = (baseTriangulo * alturaTriangulo) / 2f;
    }
    void CalcularAreaCuadrado()
    {
       areaCuadrdado = ladoCuadrado* ladoCuadrado;
    }
    void CalcularAreaCirculo()
    {
       areaCirculo = Mathf.PI * Mathf.Pow(radio, 2);
    }


}
