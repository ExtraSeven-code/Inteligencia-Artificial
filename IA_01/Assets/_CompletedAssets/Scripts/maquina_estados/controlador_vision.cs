using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador_vision : MonoBehaviour
{
    public Transform Ojos;
    public float rangoVision = 20f;
    public Vector3 offset = new Vector3(0f, 0.5f, 0f);

    private controlador_nav_mesh controldarNavMesh;
    // Start is called before the first frame update
    void Start()
    {
        controldarNavMesh = GetComponent<controlador_nav_mesh>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool PuedoVerAlJugador(out RaycastHit hit, bool mirarHaciaeljugador = false)
    {
        Vector3 vectorDireccion;
        if (mirarHaciaeljugador)
        {
            vectorDireccion = (controldarNavMesh.perseguirObjetivo.position + offset) - Ojos.position;
        }
        else
        {
            vectorDireccion = Ojos.forward;
        }
            return Physics.Raycast(Ojos.position, vectorDireccion, out hit, rangoVision) && hit.collider.CompareTag("Player");
    }
}
