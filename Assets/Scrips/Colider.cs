using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colider : MonoBehaviour
{
    private Transform posicionInicio; // Referencia al objeto "PosicionInicio"

    private void Start()
    {
        // Encuentra el objeto "PosicionInicio" por su nombre en la escena
        GameObject posicionInicioObject = GameObject.Find("PosicionInicio");

        // Verifica si se encontr� el objeto
        if (posicionInicioObject != null)
        {
            posicionInicio = posicionInicioObject.transform;
        }
        else
        {
            Debug.LogError("No se encontr� el objeto 'PosicionInicio'. Aseg�rate de que exista en la escena.");
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Damage"))
        {
            // Mueve al jugador a la posici�n de inicio si existe la referencia a "PosicionInicio"
            if (posicionInicio != null)
            {
                transform.position = posicionInicio.position;
            }
        }
    }

}

