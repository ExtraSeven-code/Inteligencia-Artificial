using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramgo_ataque : MonoBehaviour
{
    public configuracion_ataque configuracion_ataque;
    private bool puedeAtacar = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Presa"))
        {
            puedeAtacar = true;
            Debug.Log("puedo atacar");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Presa"))
        {
            puedeAtacar = false;
            Debug.Log("ya no se puedo atacar");
        }
    }

    void Update()
    {
        if (puedeAtacar && Input.GetMouseButtonDown(0))
        {
            configuracion_ataque.realizar_ataque();
        }
    }
}
