using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movimiento_rosa : MonoBehaviour
{
    public Transform[] puntos;
    private int siguiente_punto;
    private controlador_navmes_rosa controlador_Nrosa;
    private void Awake()
    {
        controlador_Nrosa = GetComponent<controlador_navmes_rosa>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (controlador_Nrosa.HemosllegadoR())
        {
            siguiente_punto = (siguiente_punto +1) % puntos.Length;
            actualizarpuntosdedestino();
        }

    }

    public void OnEnable()
    {
        actualizarpuntosdedestino();
        
    }

    public void actualizarpuntosdedestino()
    {
        controlador_Nrosa.ActualizarPuntoDestinoNavMeshR(puntos[siguiente_punto].position);
    }
}
