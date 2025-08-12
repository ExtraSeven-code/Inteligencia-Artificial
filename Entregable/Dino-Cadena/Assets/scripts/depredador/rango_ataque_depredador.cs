using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rango_ataque_depredador : MonoBehaviour
{
    public atributos_player atributos_Player;
    public bool depredador_puede_atacar = false;
    public float intervalo_ataque = 2f;
    private Coroutine rutinaAtaque;
    public int daño;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("te pueden atacar");
            depredador_puede_atacar = true;

            if (rutinaAtaque == null) 
            {
                rutinaAtaque = StartCoroutine(Tons());
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("ya no te pueden atacar");
            depredador_puede_atacar = false;

            if (rutinaAtaque != null)
            {
                StopCoroutine(rutinaAtaque);
                rutinaAtaque = null;
            }
        }
    }

    private IEnumerator Tons()
    {
        while (depredador_puede_atacar)
        {
            atacar();
            yield return new WaitForSeconds(intervalo_ataque);
        }
    }

    private void atacar()
    {
        atributos_Player.vida -= daño;
        Debug.Log("ataque");
        
    }

}
