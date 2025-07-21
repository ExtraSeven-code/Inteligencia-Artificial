using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estado_persecucion : MonoBehaviour
{
    public Color colorestado = Color.red;

    private maquina_estado maquinaDeEstados;
    private controlador_nav_mesh controladorNavMesh;
    private controlador_vision controladorVision;

    // Start is called before the first frame update
    void Awake()
    {
        maquinaDeEstados = GetComponent<maquina_estado>();
        controladorNavMesh = GetComponent<controlador_nav_mesh>();
        controladorVision = GetComponent<controlador_vision>();
    }

    void OnEnable()
    {
        maquinaDeEstados.meshrenderindicador.material.color = colorestado; ;
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(!controladorVision.PuedoVerAlJugador(out hit, true))
        {
            maquinaDeEstados.Activarestado(maquinaDeEstados.EstadoAlerta);
            return;
        }
        controladorNavMesh.ActualizarPuntoDestinoNavMesh(controladorNavMesh.perseguirObjetivo.position);

    }
}
