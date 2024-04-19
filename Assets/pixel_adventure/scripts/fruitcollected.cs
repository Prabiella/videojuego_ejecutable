using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitcollected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Puntos puntosScript = FindObjectOfType<Puntos>(); // Encuentra el script Puntos en la escena
            if (puntosScript != null)
            {
                puntosScript.AgarrarMoneda(); // Llama al método AgarrarMoneda() del script Puntos
            }
            Destroy(gameObject, 0.5f);
        }
    }
}
