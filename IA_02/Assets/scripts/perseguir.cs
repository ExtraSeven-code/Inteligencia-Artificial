using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class perseguir : MonoBehaviour
{
    public Transform obejtivo;
    public NavMeshAgent perseguidr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        perseguidr.destination = obejtivo.position;
    }
}
