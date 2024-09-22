using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    // como no se determinar el num max y min, pongo de ejemplos estos
    [SerializeField] int numMax = 100;
    [SerializeField] int numMin = 1;
    [SerializeField] int suma;
 
    void Start()
    {
        Sumar(1,100);
    }
    int Sumar(int num1, int num2)
    {
        for (int i = numMin; i <= numMax; i++)
        {
            suma += 1;
        }
        return suma;
    }

   
}
