using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class cazando : MonoBehaviour
{
    public MeshRenderer estado;
    public Color estado_color;
    private NavMeshAgent agent;
    private bool en_cazeria = false;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(en_cazeria && player != null)
        {
            agent.SetDestination(player.position);
            estado.material.color = estado_color;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player = other.transform;
            en_cazeria = true;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            en_cazeria = false;
            estado.material.color = Color.white;
        }
    }
}
