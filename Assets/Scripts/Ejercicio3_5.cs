using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    //circunferencia
    [SerializeField] float radio;
    [SerializeField] float longitid;
    [SerializeField] float area;
    void Start()
    {
        area = Mathf.PI * Mathf.Pow(radio, 2);
        longitid = 2 * Mathf.PI * radio;

        Debug.Log("El area de la circunferencia es: " + area);
        Debug.Log("La longitud de la circunferencia es: " + longitid);
    }

    
    void Update()
    {
        
    }
}
