using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    int vida, da�o, tipo;
    void Start()
    {
        if (tipo == 1)
        {
            da�o = 350; vida = 650;
            Debug.Log("Da�o: " + da�o + "Vida: " + vida);
        }
        else if(tipo == 2)
        {
            da�o = 300; vida = 550;
            Debug.Log("Da�o: " + da�o + "Vida: " + vida);
        }
        else if(tipo == 3)
        {
            da�o = 300; vida = 500;
            Debug.Log("Da�o: " + da�o + "Vida: " + vida);
        }
        else if (tipo == 4)
        {
            da�o = 310; vida = 460;
            Debug.Log("Da�o: " + da�o + "Vida: " + vida);
        }
        else if( tipo == 5)
        {
            da�o = 280; vida = 490;
            Debug.Log("Da�o: " + da�o + "Vida: " + vida);
        }
        else
        {
            da�o = 360; vida = 520;
            Debug.Log("Da�o: " + da�o + "Vida: " + vida);
        }
    }
    void Update()
    {
        
    }
}
