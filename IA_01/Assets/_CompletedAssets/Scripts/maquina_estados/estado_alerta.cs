using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estado_alerta : MonoBehaviour
{
    public float velocidadgirobusqueda = 120f;
    public float duracionbusqueda = 4;
    public Color colorestado = Color.yellow;
    private maquina_estado maquinadeestado;
    private controlador_nav_mesh controladornamesh;
    private controlador_vision controladorVsion;
    private float tiempobusqueda;
    // Start is called before the first frame update
    void Awake()
    {
        maquinadeestado = GetComponent<maquina_estado>();
        controladornamesh = GetComponent<controlador_nav_mesh>();
        controladorVsion = GetComponent<controlador_vision>();
    }
    void OnEnable()
    {
        maquinadeestado.meshrenderindicador.material.color = colorestado;
        controladornamesh.DetenerNavMeshAgent();
        tiempobusqueda = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (controladorVsion.PuedoVerAlJugador(out hit))
        {
            controladornamesh.perseguirObjetivo = hit.transform;
            maquinadeestado.Activarestado(maquinadeestado.EstadoPersecucion);
            return;
        }
        transform.Rotate(0f, velocidadgirobusqueda * Time.deltaTime, 0f);
        tiempobusqueda += Time.deltaTime;
        if(tiempobusqueda >= duracionbusqueda)
        {
            maquinadeestado.Activarestado(maquinadeestado.EstadoPatrulla);
            return;
        }
    }
}
