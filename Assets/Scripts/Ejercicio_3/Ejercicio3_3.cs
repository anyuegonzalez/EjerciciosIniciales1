using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numero;
    [SerializeField] int doble;
    [SerializeField] int triple;
    void Start()
    {
        //para hallar el doble seria 
        doble = numero * 2;
        // para hallar el trple seria 
        triple = numero * 3;

        Debug.Log("El doble de " + numero + " es:" + doble);
        Debug.Log("El triple de " + numero + " es:" + triple);
    }

    
    void Update()
    {
        
    }
}
