using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaDeSalto = 10f;
    public float rangoDeVision = 10f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movimiento del personaje
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
        rb.AddForce(movimiento * velocidad);

        // Salto
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * fuerzaDeSalto, ForceMode.Impulse);
        }

        // Visión (Raycasting)
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, rangoDeVision))
        {
            if (hit.collider.gameObject.CompareTag("ObjetoInteractivo"))
            {
                Debug.Log("¡Veo un objeto interactivo!");
                // Puedes añadir aquí la lógica para interactuar con el objeto
            }
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("ObjetoInteractivo"))
        {
            Debug.Log("¡He tocado un objeto interactivo!");
            // Puedes añadir aquí la lógica para interactuar con el objeto
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ZonaDeSonido"))
        {
            Debug.Log("¡Escucho un sonido!");
            // Puedes añadir aquí la lógica para reaccionar al sonido
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("ZonaDeSonido"))
        {
            Debug.Log("¡Ya no escucho el sonido!");
        }
    }
}
