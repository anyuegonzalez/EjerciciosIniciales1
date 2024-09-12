using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    public int vidasPlayer1 = 1; public int vidasPlayer2 = 2; public int vidasPlayer3 = 3; public int vidasPlayer4 = 4;

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
