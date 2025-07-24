using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Unity.AI.Navigation;

public class navmeshcontrol : MonoBehaviour
{
    public Transform puente;
    public NavMeshSurface surface;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        puente.Rotate(0, Time.deltaTime * 10, 0, Space.Self);
        surface.BuildNavMesh();
        
    }
}
