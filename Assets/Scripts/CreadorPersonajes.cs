using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{
    [SerializeField] Personaje link;
    [SerializeField] Personaje mario; 
    void Start()
    {
        //Link's life
        link.Vida = 100;
      
        link.Mover(3, 1, 0);
        link.Saltar();
        link.Atacar();

        
    }
}
