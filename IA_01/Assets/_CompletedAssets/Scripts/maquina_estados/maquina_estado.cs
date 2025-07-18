using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maquina_estado : MonoBehaviour
{
    [SerializeField] private MonoBehaviour EstadoPatrulla;
    [SerializeField] private MonoBehaviour EstadoAlerta;
    [SerializeField] private MonoBehaviour EstadoPersecucion;
    [SerializeField] private MonoBehaviour EstadoInicial;

    private MonoBehaviour EstadoActual;
    // Start is called before the first frame update
    void Start()
    {
        Activarestado(EstadoInicial);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Activarestado(MonoBehaviour nuevoestado)
    {
        if(EstadoActual!=null) EstadoActual.enabled = false;
        EstadoActual = nuevoestado;
        EstadoActual.enabled = true;

    }
}
