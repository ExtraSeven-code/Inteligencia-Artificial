using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estado_patrulla : MonoBehaviour
{
    public Transform[] wayPoint;
    private controlador_nav_mesh controlador_Nav_Mesh;
    private int siguienteeypoint;

    private void Awake()
    {
        controlador_Nav_Mesh = GetComponent<controlador_nav_mesh>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controlador_Nav_Mesh.Hemosllegado())
        {
            siguienteeypoint = (siguienteeypoint + 1) % wayPoint.Length;
            actualizarweyPointDestino();
        }
    }

    void OnEnable()
    {
        actualizarweyPointDestino();
    }
    void actualizarweyPointDestino()
    {
        controlador_Nav_Mesh.ActualizarPuntoDestinoNavMesh(wayPoint[siguienteeypoint].position);
    }
}
