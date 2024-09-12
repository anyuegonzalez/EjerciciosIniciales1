using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    [SerializeField] float vidaInicial = 120;
    
    void Start()
    {
        vidaInicial = 120 * 3.6f;
        Debug.Log(vidaInicial);
        vidaInicial = 120 * 7.2f;
        Debug.Log(vidaInicial);
        vidaInicial = 120 * 10.8f;
        Debug.Log(vidaInicial);

    }

    
    void Update()
    {
        
    }
}
