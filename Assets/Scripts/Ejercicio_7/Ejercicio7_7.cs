using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int numeroMax = 100;
    [SerializeField] int numeroMin =1;
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    void Start()
    {
        //no se como indicarle a unity que el numero Maximo es mayor que el numero minimo, le doy un valor yo
        //numeroMax > numeroMin;
        //numeroMax = numero2 > numero1;   
        //numeroMin = numeroMin < numero2;
        numeroMin = 1; numeroMax = 100;
        for (int i = numeroMin; numeroMin < numeroMax; i++)
        {
            Debug.Log(i);
        }
    }

}
