using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{

    // no se muy bien como terminarlo :(
    [SerializeField] int num = 17;
    bool esPrimo = true;
   
    void Start()
    {
      
        if (esPrimo)
        {
            Debug.Log("El numero es primo");
        }
        else
        {
            Debug.Log("No es primo");
        }
    }

    /*
    public bool EsPrimo()
    {
        if (num <= 2)
        {
            return false;
        }
        for (int i = 0; i < num; i++)
        {
            if(num % i == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
    */
   
}
