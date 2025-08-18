using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.AI;

public class escapar : MonoBehaviour
{
    private MeshRenderer presa;
    public float distancia_escape = 10f;
    private NavMeshAgent agent;
    private bool escapando = false;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
    
        presa = GetComponent<MeshRenderer>();
        agent = GetComponent<NavMeshAgent>();
        presa.material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (escapando && player != null)
        {
            Vector3 directionAway = (transform.position - player.position).normalized;
            Vector3 escapeTarget = transform.position + directionAway * distancia_escape;

            NavMeshHit hit;
            if (NavMesh.SamplePosition(escapeTarget, out hit, 5.0f, NavMesh.AllAreas))
            {
                agent.SetDestination(hit.position);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player= other.transform;
            escapando = true;
            Debug.Log("presa escapando");
            presa.material.color = Color.red;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            presa.material.color = Color.green;
            escapando= false;
            agent.ResetPath();
        }
    }
}
