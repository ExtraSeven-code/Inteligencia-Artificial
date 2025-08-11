using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rango_ataque_depredador : MonoBehaviour
{
    public bool depredador_puede_atacar = false;
    public float tiempo_ataque;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        atacar();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("te pueden atacar");
            depredador_puede_atacar = true;
            

        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            tiempo_ataque -= 1 * Time.deltaTime;
            if (tiempo_ataque < 0)
            {
                tiempo_ataque = 2;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("ya no te pueden atacar");
            depredador_puede_atacar=false;
            tiempo_ataque = 2;
        }
    }

    public void atacar()
    {
        if(tiempo_ataque == 0 && depredador_puede_atacar)
        {
            Debug.Log("atacar");
        }
    }

}
