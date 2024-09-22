using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{
    [SerializeField] int numero = 1;
    void Start()
    {
        while(numero <= 100)
        {
            Debug.Log(numero);
            numero++;
        }
    }

}
