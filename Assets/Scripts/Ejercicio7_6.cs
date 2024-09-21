using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ejercicio7_6 : MonoBehaviour
{
    int num;
    int numeroDeAhora;
    void Start()
    {
        //for
        if(num > 0)
        {
            for (int numeroDeAhora = num; numeroDeAhora >= -num; numeroDeAhora--)
            {
                Debug.Log(numeroDeAhora);
            }
        }
        //while
        if(num > 0)
        {
            while (numeroDeAhora >= -num)
            {
                Debug.Log (numeroDeAhora);
                numeroDeAhora--;
            }
        }
        
    }

  
}
