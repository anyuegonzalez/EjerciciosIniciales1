using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    // no se por donde continuar este
    [SerializeField] float velocidadKMh = 120f;
    [SerializeField] float velocidadMs;
    void Start()
    {
        Debug.Log("La velocidad Km/h ahora es m/s y es: " + velocidadMs);
    }

    
    void Update()
    {
        
    }
    float ConvertirKMHaMs()
    {
        velocidadKMh = 1000 / 3600;
        return velocidadMs;
    }
}
