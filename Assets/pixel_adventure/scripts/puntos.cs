using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public Text textoPuntos;
    public int monedas = 0;

    void Start()
    {
        // Inicializar las monedas al inicio del juego
        monedas = 0;
    }

    void LateUpdate()
    {
        // Actualizar el texto de los puntos
        ActualizarTextoPuntos();
    }

    // Metod para actualizar el texto de los puntos
    void ActualizarTextoPuntos()
    {
        // Asegurarse de que el componente Text esté asignado
        if (textoPuntos != null)
        {
            // Convertir el valor de monedas a string y asignarlo al texto
            textoPuntos.text = monedas.ToString();
        }
        else
        {
            Debug.LogWarning("El componente Text no está asignado en el script Puntos.");
        }
    }

    // Metod para agregar una moneda
    public void AgarrarMoneda()
    {
        // Incrementar el valor de monedas cuando el jugador agarra una moneda
        monedas++;
    }
}
