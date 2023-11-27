using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DatosJugador : MonoBehaviour
{
    public float vidaJugadorInicial;
    private float vidaActual;
    public Slider barraVidaJugador;

    private int numPocionesVida;

    public TMPro.TextMeshProUGUI textoPocionesVida;

    public GameObject panelGameOver;

    private void Start()
    {
        vidaActual = vidaJugadorInicial;
        barraVidaJugador.value = vidaActual;
        numPocionesVida = 0;
        panelGameOver.SetActive(false);
    }

    private void Update()
    {
        barraVidaJugador.value = vidaActual;

        textoPocionesVida.text = numPocionesVida.ToString();

        if (Input.GetKeyDown(KeyCode.E))
        {
            usarPocionVida();
        }
    }

    public void recibirDano(float dmg)
    {
        vidaActual -= dmg;
        Debug.Log(vidaActual);

        if (vidaActual <= 0)
        {
            panelGameOver.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            Time.timeScale = 0f;
        }
    }

    public void curarVida(float cura)
    {
        vidaActual += cura;

        if (vidaActual > vidaJugadorInicial)
        {
            vidaActual = vidaJugadorInicial;
        }
    }

    public void addPocionVida()
    {
        textoPocionesVida.color = Color.white;
        numPocionesVida++;
        Debug.Log(numPocionesVida);
    }

    private void restarPocionVida()
    {
        numPocionesVida--;
        Debug.Log(numPocionesVida);
    }

    private void usarPocionVida()
    {
        if (vidaActual < vidaJugadorInicial)
        {
            if (numPocionesVida > 0)
            {

                curarVida(20);
                restarPocionVida();
            }
            else
            {
                textoPocionesVida.color = Color.red;
            }
        }
    }
}

