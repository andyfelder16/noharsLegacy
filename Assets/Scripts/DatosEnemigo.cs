using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosEnemigos : MonoBehaviour
{
    public float danoEnemigo;
    public float vidaEnemigo;
    private float vidaActualEnemigo;
    public Slider barraVidaEnemigo;

    private DatosJugador datoJugador;

    [SerializeField] private float tiempoEntreDano;
    private float tiempoSiguienteDano;

    private void Start()
    {
        vidaActualEnemigo = vidaEnemigo;
    }

    private void Update()
    {
        tiempoSiguienteDano -= Time.deltaTime;
        barraVidaEnemigo.value = vidaActualEnemigo;
    }

    // CUANDO ESTEN LAS ANIMACIONES EL DAñO SE HARñ DESDE EL SCRIPT DEL JUGADOR

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            datoJugador = other.GetComponent<DatosJugador>();

            if (tiempoSiguienteDano <= 0 && datoJugador != null)
            {
                datoJugador.recibirDano(15);
                tiempoSiguienteDano = tiempoEntreDano;
                Debug.Log("Daño aplicado desde el enemigo: " + datoJugador.vidaActual);
            }
        }

        /*if (other.CompareTag("ArmaPlayer"))
        {
            // Recoger la variable daño del jugador
            float daño = 10;

            recibirDaño(daño);
        }*/
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            datoJugador = null;
        }
    }

    public void recibirDaño(float daño)
    {
        vidaActualEnemigo -= daño;

        if (vidaActualEnemigo <= 0)
        {
            Destroy(gameObject);
        }
    }
}

