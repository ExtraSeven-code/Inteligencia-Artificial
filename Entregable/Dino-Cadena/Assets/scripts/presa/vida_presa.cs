using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida_presa : MonoBehaviour
{
    public float vida;
    public atributos_player atributos;
    public configuracion_ataque configuracion_Ataque;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Daño_Player"))
        {
            vida -= atributos.daño;
            Debug.Log("restar vida");
            configuracion_Ataque.collision_ataque.SetActive(false);
        }
        if (vida < 0)
        {
            Destroy(gameObject);
        }
    }

















}
