using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    [SerializeField] float vidaInicial = 120;
    [SerializeField] float vidaTotal;
    [SerializeField] float vidaResta;
    
    void Start()
    {
        vidaTotal = vidaInicial * 0.03f;
        vidaTotal = vidaInicial - vidaResta;
        Debug.Log(vidaInicial);
        vidaTotal = vidaInicial * 0.06f;
        vidaTotal = vidaInicial - vidaResta;
        Debug.Log(vidaInicial);
        vidaTotal = vidaInicial * 0.03f;
        vidaTotal = vidaInicial - vidaResta;
        Debug.Log(vidaInicial);

    }

    
    void Update()
    {
        
    }
}
