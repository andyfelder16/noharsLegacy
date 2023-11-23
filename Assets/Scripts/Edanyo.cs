using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edanyo : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDano;
    private float tiempoSiguienteDano;
    private DatosJugador datoJugador;

    public void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            datoJugador = other.GetComponent<DatosJugador>();
            tiempoSiguienteDano -= Time.deltaTime;

            if(tiempoSiguienteDano <= 0 && datoJugador != null)
            {
                datoJugador.recibirDano(15);
                tiempoSiguienteDano = tiempoEntreDano;
                Debug.Log("Daño aplicado.");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            datoJugador = null;
        }
    }
}
