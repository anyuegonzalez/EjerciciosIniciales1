using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    // voy a darle valores al num max y min inventados porque no se determinar el num mayor y menor
    [SerializeField] int numeroMax =100;
    [SerializeField] int numeroMin =1;
    void Start()
    {
        for (int i = numeroMin; numeroMin < numeroMax; i++)
        {
            if ( i == 2)
            {
                Debug.Log(i);
            }
            
        } 
    }

   
}
