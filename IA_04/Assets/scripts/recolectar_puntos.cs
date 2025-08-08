using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class recolectar_puntos : MonoBehaviour
{
    public int puntos;
    private Controlador_sonido controlador_sonido;
    // Start is called before the first frame update
    void Start()
    {
        controlador_sonido = FindObjectOfType<Controlador_sonido>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("puntos"))
        {
            controlador_sonido.seleccionar_audio(1, 1);
            puntos += 1 ;
            Debug.Log("punto obtenido");
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("puntaje", puntos);
        }
    }

}
