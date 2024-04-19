using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class juego : MonoBehaviour
{
   public void Jugar()
    {
        SceneManager.LoadScene("JuegoUnity");
    }

    public void Salir()
    {
        Debug.Log("Salir..");
        Application.Quit();
    }
}
