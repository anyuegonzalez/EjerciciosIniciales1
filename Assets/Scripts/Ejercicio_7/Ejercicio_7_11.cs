using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_7_11 : MonoBehaviour
{
    [SerializeField] int num = 5;
    void Start()
    {
        MostrarTablaDeMultiplicar(num);
    }
    void MostrarTablaDeMultiplicar(int num)
    {
        Debug.Log("La tabla de multiplicar es la siguiente: ");
        for (int i = 1; i <= 10; i++)
        {
            int resultado = num * 10;
            Debug.Log(resultado);
        }
    }

   
}
