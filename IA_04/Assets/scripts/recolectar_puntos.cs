using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class recolectar_puntos : MonoBehaviour
{
    public int puntos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("puntos"))
        {
            puntos += 1 ;
            Debug.Log("punto obtenido");
            Destroy(other.gameObject);
            PlayerPrefs.SetString("puntaje", puntos.ToString());
        }
    }

}
