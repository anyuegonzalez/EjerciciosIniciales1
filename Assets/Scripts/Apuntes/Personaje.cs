using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    //COMO se define un personaje. 

    // propiedades o atributos
   private string nombre;
   private float vida;
   private float altura;
   private float velocidad;
    public float Vida { get => vida; set => vida = value; }

    // QUÉ es lo que hace un personaje
    //funcionalidades
    public void Mover(float x, float y, float z)
    {

    }
    public void Atacar()
    {

    }
    public void Saltar()
    {

    }
}
