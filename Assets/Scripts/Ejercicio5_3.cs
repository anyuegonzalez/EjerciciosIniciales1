using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int vidaNumero1;
    [SerializeField] int vidaNumero2;
    void Start()
    {
        vidaNumero1 = vidaNumero2;  
    }

   
    void Update()
    {
        
    }
}
