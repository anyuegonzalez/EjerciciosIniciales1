using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int velocidadJugador1;
    [SerializeField] int velocidadJugador2;
    [SerializeField] int velocidadJugador3;
    void Start()
    {
        if(velocidadJugador1 >= velocidadJugador2 && velocidadJugador1 >= velocidadJugador3)
        {
            Debug.Log("El jugador 1 atacará primero con una velocidad de: " + velocidadJugador1);
        }
        else if(velocidadJugador2 >= velocidadJugador1 && velocidadJugador2 >= velocidadJugador3)
        {
            Debug.Log("El jugador 2 atacará primero con una velocidad de: " + velocidadJugador2);
        }
        else
        {
            Debug.Log("El jugador 3 atacará primero con una velocidad de: " + velocidadJugador3);
        }
    }

   
    void Update()
    {
        
    }
}
