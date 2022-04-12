using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comidaAnimales : MonoBehaviour
{    public string animal;
    public int dias;
    // Start is called before the first frame update
    void Start()
    {     if (dias > 3)
        {
            switch (animal){
                case "G":
                    int comidaGato = dias * 300;
                    int precioGato = comidaGato * 80;
                    Debug.Log("Para ese periodo se necesitan " + comidaGato + " gramos de alimento");
                    Debug.Log("El costo de la comida va a ser " + precioGato + " pesos");
                    break;
                case "PP":
                    int comidaPerroP = dias * 400;
                    int precioPerroP = comidaPerroP * 80;
                    Debug.Log("Para ese periodo se necesitan " + comidaPerroP + " gramos de alimento");
                    Debug.Log("El costo de la comida va a ser " + precioPerroP + " pesos");
                    break;                
                case "PG":
                    int comidaPerroG = dias * 700;
                    int precioPerroG = comidaPerroG * 80;
                    Debug.Log("Para ese periodo se necesitan " + comidaPerroG + " gramos de alimento");
                    Debug.Log("El costo de la comida va a ser " + precioPerroG + " pesos");
                    break;
                default:
                    Debug.Log("No ingresaste un animal valido");
                    break;


            }
        }
        else
        {
            Debug.Log("Ingresaste una cantidad de dias incorrrecta. Minimo 3 dias.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
