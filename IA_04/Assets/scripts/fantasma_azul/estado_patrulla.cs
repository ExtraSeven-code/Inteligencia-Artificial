using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estado_patrulla : MonoBehaviour
{
    public Transform[] wayPoint;
    public Color colorestado = Color.green;
    private maquina_estado maquinadeestados;
    private controlador_nav_mesh controlador_Nav_Mesh;
    private controlador_vision controladordevision;
    private int siguienteeypoint;

    private void Awake()
    {
        maquinadeestados = GetComponent<maquina_estado>();
        controlador_Nav_Mesh = GetComponent<controlador_nav_mesh>();
        controladordevision = GetComponent<controlador_vision>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(controladordevision.PuedoVerAlJugador(out hit))
        {
            controlador_Nav_Mesh.perseguirObjetivo = hit.transform;
            maquinadeestados.Activarestado(maquinadeestados.EstadoPersecucion);
            return;
        }
        if (controlador_Nav_Mesh.Hemosllegado())
        {
            siguienteeypoint = (siguienteeypoint + 1) % wayPoint.Length;
            actualizarweyPointDestino();
        }
    }

    void OnEnable()
    {
        maquinadeestados.meshrenderindicador.material.color = colorestado;
        actualizarweyPointDestino();
    }
    void actualizarweyPointDestino()
    {
        controlador_Nav_Mesh.ActualizarPuntoDestinoNavMesh(wayPoint[siguienteeypoint].position);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && enabled)
        {
            maquinadeestados.Activarestado(maquinadeestados.EstadoAlerta);
        }
        
    }
}
