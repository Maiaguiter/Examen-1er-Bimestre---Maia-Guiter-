using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public int dia;
    public string codigo;

    // Start is called before the first frame update
    void Start()
    {
        int G = dia * 300;
        int PP = dia * 400;
        int PG = dia * 700;
        int precioG = G / 100 * 80;
        int precioPP = PP / 100 * 80;
        int precioPG = PG / 100 * 80;

        if (dia < 3)
        {
            Debug.Log("Error, la cantidad de dias debera ser mayor a tres");
        }
        if (codigo != "G" && codigo != "PP" && codigo != "PG")
        {
            Debug.Log("Error, el codigo ingresado no es valido");
        }
        else if (codigo == "G")
        {
            Debug.Log("Para ese periodo se necesitan " + G + " gramos y saldra " + precioG + "pesos");
        }
        else if (codigo == "PP")
        {
            Debug.Log("Para ese periodo se necesitan " + PP + " gramos y saldra " + precioPP + "pesos");
        }
        else if (codigo == "PG")
        {
            Debug.Log("Para ese periodo se necesitan " + PG + " y saldra " + precioPG + "pesos");
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
