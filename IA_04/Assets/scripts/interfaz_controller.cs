using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class interfaz_controller : MonoBehaviour
{
    public controlador_vida controlador_vida;
    public TextMeshProUGUI text_puntos; 
    public recolectar_puntos recolectarpuntos;
    public GameObject vida1;
    public GameObject vida2;
    public GameObject vida3;
    public GameObject vida4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        actualizar_puntos();
        controllador_vida();
    }

    public void actualizar_puntos()
    {
        text_puntos.text = recolectarpuntos.puntos.ToString();
    }
    public void controllador_vida()
    {
        if (controlador_vida.vida_pacman == 4)
        {
            vida1.SetActive(true);
            vida2.SetActive(true);
            vida3.SetActive(true);
            vida4 .SetActive(true);
        }
        if (controlador_vida.vida_pacman == 3)
        {
            vida1.SetActive(true);
            vida2.SetActive(true);
            vida3.SetActive(true);
            vida4.SetActive(false);
        }
        if (controlador_vida.vida_pacman == 2)
        {
            vida1.SetActive(true);
            vida2.SetActive(true);
            vida3.SetActive(false);
            vida4.SetActive(false);
        }
        if (controlador_vida.vida_pacman == 1)
        {
            vida1.SetActive(true);
            vida2.SetActive(false);
            vida3.SetActive(false);
            vida4.SetActive(false);
        }
        if (controlador_vida.vida_pacman == 0)
        {
            vida1.SetActive(false);
            vida2.SetActive(false);
            vida3.SetActive(false);
            vida4.SetActive(false);
        }
    }
}
