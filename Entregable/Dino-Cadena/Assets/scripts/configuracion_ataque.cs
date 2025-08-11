using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class configuracion_ataque : MonoBehaviour
{
    public atributos_player atributos;
    public vida_presa presa;
    public GameObject collision_ataque;

    private void Start()
    {
        
    }

    public void realizar_ataque()
    {
            collision_ataque.SetActive(true);  
    }

    
}
