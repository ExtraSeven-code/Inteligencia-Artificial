using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rango_ataque_depredador : MonoBehaviour
{
    public MeshRenderer estado;
    public Color estado_color;
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
            estado.material.color = estado_color;
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
            estado.material.color = Color.white;

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
            yield return new WaitForSeconds(intervalo_ataque);
            atacar();
        }
    }

    private void atacar()
    {
        atributos_Player.vida -= daño;
        Debug.Log("ataque");
        
    }

}
