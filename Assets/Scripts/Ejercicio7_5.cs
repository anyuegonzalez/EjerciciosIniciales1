using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero = 100;
    int numero1 = 1;
    void Start()
    {
      if(numero > 0)
      {
            while(numero1 <= numero)
            {
                Debug.Log(numero);
                numero1++;
            }
      }
      else if(numero > 0)
      {
         for(int i = 1; numero1 <= numero; i++)
         {
            Debug.Log (numero1);
         }
      }
    }

    
}
