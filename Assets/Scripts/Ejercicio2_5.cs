using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    [SerializeField] int vidasPlayer1 = 1; [SerializeField] int vidasPlayer2 = 2; [SerializeField] int vidasPlayer3 = 3; [SerializeField] int vidasPlayer4 = 4;

    void Start()
    {
       vidasPlayer2 = 2; 

       vidasPlayer2 = vidasPlayer3;
       vidasPlayer3 = vidasPlayer1;
       vidasPlayer1 = vidasPlayer4;
       vidasPlayer4 = vidasPlayer2;
    }

    void Update()
    {
        
    }
}
