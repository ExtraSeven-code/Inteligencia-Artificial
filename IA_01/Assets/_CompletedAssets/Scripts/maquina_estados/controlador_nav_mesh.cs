using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class controlador_nav_mesh : MonoBehaviour
{
    [HideInInspector]
    public Transform perseguirObjetivo;
    private NavMeshAgent navmeshagent;

    // Start is called before the first frame update
    void Awake()
    {
        navmeshagent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    public void ActualizarPuntoDestinoNavMesh(Vector3 puntoDestino)
    {
        navmeshagent.destination = puntoDestino;
        navmeshagent.Resume();
    }
    public void ActualizarPuntoDestinoNavMesh()
    {
        ActualizarPuntoDestinoNavMesh(perseguirObjetivo.position);
    }
    public void DetenerNavMeshAgent()
    {
        navmeshagent.Stop();
    }
    public bool Hemosllegado()
    {
        return navmeshagent.remainingDistance <= navmeshagent.stoppingDistance && !navmeshagent.pathPending;
    }
}
