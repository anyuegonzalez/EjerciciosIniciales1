using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    [SerializeField] bool par = true;
    [SerializeField] int nivel;
    void Start()
    {
        Debug.Log("El nivel del personaje es: " + nivel);
        if (par == true) 
        {
            par = true;
        }
        else if (par == false)
        {
           par = false;
        }
    }

    
    void Update()
    {
        
    }
}
