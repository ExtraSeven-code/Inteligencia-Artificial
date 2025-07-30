using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class generar_puntos : MonoBehaviour
{
    public GameObject prefabBolita;
    public float rango;
    public Transform centroZona;
    public float intervalo; 
    public int cantidadMaxima;

    private List<GameObject> bolitasActivas = new List<GameObject>();

    void Start()
    {
        InvokeRepeating(nameof(GenerarBolitaNavMesh), 1f, intervalo);
    }

    void GenerarBolitaNavMesh()
    {
        
        bolitasActivas.RemoveAll(b => b == null); 

        if (bolitasActivas.Count >= cantidadMaxima)
            return;

        Vector3 puntoAleatorio = centroZona.position + Random.insideUnitSphere * rango;
        puntoAleatorio.y = centroZona.position.y;

        NavMeshHit hit;
        if (NavMesh.SamplePosition(puntoAleatorio, out hit, 5.0f, NavMesh.AllAreas))
        {
            GameObject nuevaBolita = Instantiate(prefabBolita, hit.position, Quaternion.identity);
            bolitasActivas.Add(nuevaBolita);
        }
    }
}
