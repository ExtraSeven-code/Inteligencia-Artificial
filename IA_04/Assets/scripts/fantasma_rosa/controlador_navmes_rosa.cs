using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class controlador_navmes_rosa : MonoBehaviour
{
    [HideInInspector]
    private Transform perseguirObjetivo;
    private NavMeshAgent navmeshagente;

    // Start is called before the first frame update
    void Awake()
    {
        navmeshagente = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    public void ActualizarPuntoDestinoNavMeshR(Vector3 puntoDestino)
    {
        navmeshagente.destination = puntoDestino;
        navmeshagente.Resume();
    }

    public bool HemosllegadoR()
    {
        return navmeshagente.remainingDistance <= navmeshagente.stoppingDistance && !navmeshagente.pathPending;
    }
}
