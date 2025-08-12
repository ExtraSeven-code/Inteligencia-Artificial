using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador_vida : MonoBehaviour
{
    public atributos_player atributo;
    public float tiempo_daño_hambre_sed;
    public int daño_segundo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(tick_daño());
        StartCoroutine(bajar_sed_hambre());
    }

    // Update is called once per frame
    void Update()
    {
        controldar_hambre_sed();
    }

    public void hambre_sed_bajarvida()
    {
        if (atributo.hambre<= 0)
        {
            atributo.vida -= daño_segundo;
            Debug.Log("tienes hambre");
        }
        if (atributo.sed <= 0)
        {
            atributo.vida -= daño_segundo;
            Debug.Log("tienes sed");
        }
    }
    IEnumerator tick_daño()
    {
        while (true)
        {
            yield return new WaitForSeconds(tiempo_daño_hambre_sed);
            hambre_sed_bajarvida();
        }
    }

    IEnumerator bajar_sed_hambre()
    {
        while (true)
        {
            bajar_hambre_sed();
        }
    }

    public void bajar_hambre_sed()
    {
        atributo.hambre -= 1;
        atributo.sed -= 1;

    }

    public void controldar_hambre_sed()
    {
        if (atributo.hambre <= 0)
        {
            atributo.hambre = 0;
        }
        if (atributo.hambre >= 100)
        {
            atributo.hambre = 100;
        }
        if(atributo.sed >= 100)
        {
            atributo.sed = 100;
        }
        if(atributo.sed <= 0)
        {
            atributo.sed = 0;
        }
    }
}
